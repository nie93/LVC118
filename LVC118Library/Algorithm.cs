using System;
using System.IO;
using System.Text;
using ECAClientFramework;
using ECAClientUtilities.API;
using LVC118.Adapters;
using LVC118.Model.LVC118Data;
using LVC118.VcControlDevice;

namespace LVC118
{
    public static class Algorithm
    {
        static VoltVarControllerAdapter vca;
        static VoltVarController PreviousFrame;

        static Algorithm()
        {
            /*
             * Testing Files Configurations
             * test1.xml    -   Verify if the controller can RAISE both transformers' taps when voltages on both buses are lower than the limit (VLLIM = 114.5kV)
             * test2.xml    -   Verify if the controller is still able to operate (VLLIM = 114.5kV), when the other transformer's tap has reached the highest tap position (16)
             * test3.xml    -   Verify if the controller can switch ON the capacitor bank when the voltage in Pamplin substation reach the lower limit (Clov = 113.5kV)
             * test4.xml    -   Verify if the controller can switch OFF the capacitor bank when the voltage in Crewe substation reach the higher limit (Chiv = 119.7kV)
            */
            string configurationPathName = (@"C:\Users\niezj\Documents\dom\ShadowSys118\ShadowSysConfiguration\prev_SysConfigFrame.xml");
            vca = new VoltVarControllerAdapter()
            {
                ConfigurationPathName = configurationPathName
            };

            vca.Initialize();
            PreviousFrame = new VoltVarController();
            PreviousFrame = VoltVarController.DeserializeFromXml(configurationPathName);
        }

        public static Hub API { get; set; }

        internal class Output
        {
            public Outputs OutputData = new Outputs();
            public _OutputsMeta OutputMeta = new _OutputsMeta();
            public static Func<Output> CreateNew { get; set; } = () => new Output();
        }

        public static void UpdateSystemSettings()
        {
            SystemSettings.InputMapping = "LVC118Data_InputMapping";
            SystemSettings.OutputMapping = "LVC118Data_OutputMapping";
            SystemSettings.ConnectionString = @"server=localhost:6190; interface=0.0.0.0";
            SystemSettings.FramesPerSecond = 1;
            SystemSettings.LagTime = 5;
            SystemSettings.LeadTime = 1;
        }

        internal static Output Execute(Inputs inputData, _InputsMeta inputMeta)
        {
            Output output = Output.CreateNew();

            #region [ Environment Settings ]
            string MainFolderPath = (@"C:\Users\niezj\Documents\dom\LVC118\");
            string DataFolderPath = Path.Combine(MainFolderPath, @"Data");
            string LogFolderPath = Path.Combine(MainFolderPath, @"Log");

            string[] LogFileNameList = Directory.GetFiles(LogFolderPath, "CtrlDecisionLog_*.xml");
            string LogFileName = $"CtrlDecisionLog_{LogFileNameList.Length + 1:000}_{DateTime.UtcNow:yyyyMMdd_HHmmssfff}.xml";

            string LogFilePath = Path.Combine(LogFolderPath, LogFileName);

            bool EnableVoltageControlsMessageOutput = true;
            #endregion

            // Extract inputData from openECA then Call SubRoutine
            vca.GetData(inputData, inputMeta, PreviousFrame);

            // Logging control decision to *.xml files
            vca.SerializeToXml(LogFilePath);

            // Store Current vca.InputFrame to previous.InputFrame for the next InputFrame 
            //PreviousFrame = vca.InputFrame;
            //PreviousFrame.SerializeToXml(@"C:\Users\niezj\Documents\dom\ShadowSys118\ShadowSysConfiguration\ctrl_SysConfigFrame.xml");

            // Output ActionSignals to ShadowSys118
            //output.OutputData.ActTxRaise = 1;
            //output.OutputData.ActTxLower = 1;
            //output.OutputData.ActSn1Close = 1;
            //output.OutputData.ActSn1Trip = 1;
            //output.OutputData.ActSn2Close = 1;
            //output.OutputData.ActSn2Trip = 1;

            try
            {
                // TODO: Implement your algorithm here...
                // You can also write messages to the main window:


                #region [ Write openECA Client Windows Message]
                if (EnableVoltageControlsMessageOutput)
                {
                    StringBuilder _message = new StringBuilder();
                    _message.AppendLine($" ================= LVC118 Analytics ================== ");
                    _message.AppendLine($"          RunTime: {DateTime.Now: yyyy-MM-dd  HH:mm:ss.fff}");
                    _message.AppendLine($" ------------------- ActionChannel ------------------- ");
                    _message.AppendLine($"       ActTxRaise:  {output.OutputData.ActTxRaise}");
                    _message.AppendLine($"       ActTxLower:  {output.OutputData.ActTxLower}");
                    _message.AppendLine($"      ActSn1Close:  {output.OutputData.ActSn1Close}");
                    _message.AppendLine($"       ActSn1Trip:  {output.OutputData.ActSn1Trip}");
                    _message.AppendLine($"      ActSn2Close:  {output.OutputData.ActSn2Close}");
                    _message.AppendLine($"       ActSn2Trip:  {output.OutputData.ActSn2Trip}");
                    _message.AppendLine($" ---------------- MeasurementChannel ----------------- ");
                    _message.AppendLine($"      MeasTxVoltV:  {inputData.MeasTxVoltV:0.000} Volts");
                    _message.AppendLine($"     MeasSn1VoltV:  {inputData.MeasSn1VoltV:0.000} Volts");
                    _message.AppendLine($"     MeasSn2VoltV:  {inputData.MeasSn2VoltV:0.000} Volts");
                    _message.AppendLine($"        MeasTxMwV:  {inputData.MeasTxMwV:0.000} MW");
                    _message.AppendLine($"       MeasTxMvrV:  {inputData.MeasTxMvrV:0.000} MVar");
                    _message.AppendLine($"       MeasGn1MwV:  {inputData.MeasGn1MwV:0.000} MW");
                    _message.AppendLine($"      MeasGn1MvrV:  {inputData.MeasGn1MvrV:0.000} MVar");
                    _message.AppendLine($"       MeasGn2MwV:  {inputData.MeasGn2MwV:0.000} MW");
                    _message.AppendLine($"      MeasGn2MvrV:  {inputData.MeasGn2MvrV:0.000} MVar");
                    _message.AppendLine($" ------------------- StateChannel -------------------- ");
                    _message.AppendLine($"      StateTxTapV:  {inputData.StateTxTapV}");
                    _message.AppendLine($"  StateSn1CapBkrV:  {inputData.StateSn1CapBkrV}");
                    _message.AppendLine($"  StateSn2CapBkrV:  {inputData.StateSn2CapBkrV}");
                    _message.AppendLine($"  StateSn1BusBkrV:  {inputData.StateSn1BusBkrV}");
                    _message.AppendLine($"  StateSn2BusBkrV:  {inputData.StateSn2BusBkrV}");
                    _message.AppendLine($" -------------- Control Decision Message ------------- ");
                    _message.AppendLine($" {vca.LogMessage}");
                    _message.AppendLine($" ===================================================== ");

                    MainWindow.WriteMessage(_message.ToString());
                }

                #endregion
            }
            catch (Exception ex)
            {
                // Display exceptions to the main window
                MainWindow.WriteError(new InvalidOperationException($"Algorithm exception: {ex.Message}", ex));
            }

            return output;
        }
    }
}
