﻿//******************************************************************************************************
//  VoltVarControllerAdapter.cs
//
//  Copyright © 2016, Duotong Yang  All Rights Reserved.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  11/09/2016 - Duotong Yang
//       Generated original version of source code.


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using ECAClientFramework;
using ECAClientUtilities.API;
using ECACommonUtilities;
using ECACommonUtilities.Model;
using LVC118.Model.LVC118Data;
using LVC118.Adapters;
using LVC118.VcControlDevice;
using LVC118.VcSubRoutines;
using GSF.Configuration;
using GSF.TimeSeries;
using GSF.TimeSeries.Transport;


namespace LVC118.Adapters
{
    [Serializable()]
    public class VoltVarControllerAdapter
    {
        #region [ Private Members ]
        private VoltVarController m_inputFrame;
        private string m_configurationPathName;
        private string m_logMessage;
        #endregion

        #region[ Public Properties ] 

        [XmlIgnore()]
        public VoltVarController InputFrame
        {
            get
            {
                return m_inputFrame;
            }
            set
            {
                m_inputFrame = value;
            }
        }

        [XmlIgnore()]
        public string ConfigurationPathName
        {
            get
            {
                return m_configurationPathName;
            }
            set
            {
                m_configurationPathName = value;
            }
        }

        [XmlAttribute("LogMessage")]
        public string LogMessage
        {
            get
            {
                return m_logMessage;
            }
            set
            {
                m_logMessage = value;
            }
        }

        #endregion

        #region [ Private Methods  ]

        private void InitializeInputFrame()
        {

            m_inputFrame = new VoltVarController();
            
        }

        #endregion

        #region [ Public Methods ]

        public void Initialize()
        {
            m_inputFrame = VoltVarController.DeserializeFromXml(m_configurationPathName);
            m_logMessage = null;
        }

        public void GetData(Inputs inputsData, _InputsMeta inputsMeta, VoltVarController PreviousFrame)
        {
            SubRoutine sub = new SubRoutine();
            ReadCurrentControl currCtrl = new ReadCurrentControl();
            VoltVarController Frame = new VoltVarController();


            #region [ Measurements Mapping ]

            m_inputFrame.OnNewMeasurements();

            #endregion

            #region [ openECA inputData Extraction ]

            m_inputFrame.ControlTransformers[0].TapV = inputsData.StateTxTapV;
            m_inputFrame.ControlCapacitorBanks[0].CapBkrV = inputsData.StateSn1CapBkrV;
            m_inputFrame.ControlCapacitorBanks[1].CapBkrV = inputsData.StateSn2CapBkrV;
            m_inputFrame.ControlCapacitorBanks[0].BusBkrV = inputsData.StateSn1BusBkrV;
            m_inputFrame.ControlCapacitorBanks[1].BusBkrV = inputsData.StateSn2BusBkrV;
            m_inputFrame.ControlTransformers[0].VoltsV = inputsData.MeasTxVoltV / 1000;
            m_inputFrame.ControlCapacitorBanks[0].LockvV = inputsData.MeasSn1VoltV / 1000;
            m_inputFrame.ControlCapacitorBanks[1].LockvV = inputsData.MeasSn2VoltV / 1000;
            m_inputFrame.ControlTransformers[0].MwV = inputsData.MeasTxMwV;
            m_inputFrame.ControlTransformers[0].MvrV = inputsData.MeasTxMvrV;
            m_inputFrame.SubstationInformation.G1Mw = inputsData.MeasGn1MwV;
            m_inputFrame.SubstationInformation.G1Mvr = inputsData.MeasGn1MvrV;
            m_inputFrame.SubstationInformation.G2Mw = inputsData.MeasGn2MwV;
            m_inputFrame.SubstationInformation.G2Mvr = inputsData.MeasGn2MvrV;

            #endregion

            #region [ Read The Previous Run ]

            m_inputFrame.ReadPreviousRun(PreviousFrame);

            #endregion

            #region[ Verify Program Controls ]

            currCtrl.VerifyProgramControl(m_inputFrame.SubstationAlarmDevice.LtcProgram);

            #endregion

            #region[ Adjust Control Delay Counters ]

            //#-----------------------------------------------------------------------#
            //# adjust the cap bank control delay counter, which is used to ensure:	  #
            //# a. we don't do two cap bank control within 30 minutes of each other.  #
            //# b. we don't do a tap control within a minute of a cap bank control.	  #
            //#-----------------------------------------------------------------------#

            if (m_inputFrame.SubstationInformation.Ncdel < m_inputFrame.SubstationInformation.Zcdel)
            {
                m_inputFrame.SubstationInformation.Ncdel = m_inputFrame.SubstationInformation.Ncdel + 1;
            }


            //#-----------------------------------------------------------------------#
            //# Adjust the tap control delay counter, which is used to ensure we	  #
            //# don't do a cap bank control within a minute of a tap control.	   	  #
            //#-----------------------------------------------------------------------#


            if (m_inputFrame.SubstationInformation.Ntdel < m_inputFrame.SubstationInformation.Zdel)
            {
                m_inputFrame.SubstationInformation.Ntdel = m_inputFrame.SubstationInformation.Ntdel + 1;
            }


            #endregion

            #region [ Read Curren Tx Values and Voltages ]

            m_inputFrame = currCtrl.ReadCurrentTransformerValuesAndVoltages(m_inputFrame);

            #endregion

            #region [ Check if the Previous Control Reults can Meet Our Expectation ]

            m_inputFrame = currCtrl.CheckPreviousControlResults(m_inputFrame);

            #endregion

            #region [ Call Sub Taps ]

            m_inputFrame = sub.Taps(m_inputFrame);

            #endregion

            #region [ CapBank ]

            m_inputFrame = sub.CapBank(m_inputFrame);

            #endregion

            #region [ Save before Exit ]

            m_logMessage = currCtrl.MessageInput;
            m_logMessage += sub.MessageInput;
            m_inputFrame.LtcStatus.Avv = 0;
            m_inputFrame.LtcStatus.Nins = 0;
            m_inputFrame.LtcStatus.MinVar = 99999;
            m_inputFrame.LtcStatus.MaxVar = -99999;

            #endregion

        }
        
        #endregion

        #region [ Xml Serialization/Deserialization methods ]
        public void SerializeToXml(string pathName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(VoltVarControllerAdapter));
                TextWriter writer = new StreamWriter(pathName);
                serializer.Serialize(writer, this);
                writer.Close();
            }
            catch (Exception exception)
            {
                throw new Exception("Error: XML Serialization failed.");
            }
        }

        public static VoltVarControllerAdapter DeserializeFromXml(string pathName)
        {
            try
            {
                VoltVarControllerAdapter vca = null;
                XmlSerializer deserializer = new XmlSerializer(typeof(VoltVarControllerAdapter));
                StreamReader reader = new StreamReader(pathName);
                vca = (VoltVarControllerAdapter)deserializer.Deserialize(reader);
                reader.Close();
                return vca;
            }
            catch (Exception exception)
            {
                throw new Exception("Error: XML Deserialization failed.");
            }
        }

        #endregion

    }
}
