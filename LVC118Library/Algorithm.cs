using System;
using System.IO;
using System.Text;
using ECAClientFramework;
using ECAClientUtilities.API;
using LVC118.Model.LVC118Data;

namespace LVC118
{
    public static class Algorithm
    {
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
            SystemSettings.FramesPerSecond = 30;
            SystemSettings.LagTime = 5;
            SystemSettings.LeadTime = 1;
        }

        internal static Output Execute(Inputs inputData, _InputsMeta inputMeta)
        {
            Output output = Output.CreateNew();

            bool EnableVoltageControlsMessageOutput = true;
            try
            {
                // TODO: Implement your algorithm here...
                // You can also write messages to the main window:

                #region [ Write openECA Client Windows Message]
                if (EnableVoltageControlsMessageOutput)
                {
                    StringBuilder _message = new StringBuilder();
                    _message.AppendLine($" ================= LVC118 Analytics ================== ");
                    _message.AppendLine($" ------------------- StateChannel -------------------- ");
                    _message.AppendLine($"      StateTxTapV:  {inputData.StateTxTapV}");
                    _message.AppendLine($"  StateSn1CapBkrV:  {inputData.StateSn1CapBkrV}");
                    _message.AppendLine($"  StateSn2CapBkrV:  {inputData.StateSn2CapBkrV}");
                    _message.AppendLine($"  StateSn1BusBkrV:  {inputData.StateSn1BusBkrV}");
                    _message.AppendLine($"  StateSn2BusBkrV:  {inputData.StateSn2BusBkrV}");
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
                    _message.AppendLine($" ------------------- ActionChannel ------------------- ");
                    _message.AppendLine($"       ActTxRaise:  {output.OutputData.ActTxRaise}");
                    _message.AppendLine($"       ActTxLower:  {output.OutputData.ActTxLower}");
                    _message.AppendLine($"      ActSn1Close:  {output.OutputData.ActSn1Close}");
                    _message.AppendLine($"       ActSn1Trip:  {output.OutputData.ActSn1Trip}");
                    _message.AppendLine($"      ActSn2Close:  {output.OutputData.ActSn2Close}");
                    _message.AppendLine($"       ActSn2Trip:  {output.OutputData.ActSn2Trip}");
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
