// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ECAClientFramework;
using ECAClientUtilities;
using ECACommonUtilities;
using ECACommonUtilities.Model;
using GSF.TimeSeries;

namespace LVC118.Model
{
    [CompilerGenerated]
    public class Mapper : MapperBase
    {
        #region [ Members ]

        // Fields
        private readonly Unmapper m_unmapper;

        #endregion

        #region [ Constructors ]

        public Mapper(Framework framework)
            : base(framework, SystemSettings.InputMapping)
        {
            m_unmapper = new Unmapper(framework, MappingCompiler);
            Unmapper = m_unmapper;
        }

        #endregion

        #region [ Methods ]

        public override void Map(IDictionary<MeasurementKey, IMeasurement> measurements)
        {
            SignalLookup.UpdateMeasurementLookup(measurements);
            TypeMapping inputMapping = MappingCompiler.GetTypeMapping(InputMapping);

            Reset();
            LVC118.Model.LVC118Data.Inputs inputData = CreateLVC118DataInputs(inputMapping);
            Reset();
            LVC118.Model.LVC118Data._InputsMeta inputMeta = CreateLVC118Data_InputsMeta(inputMapping);

            Algorithm.Output algorithmOutput = Algorithm.Execute(inputData, inputMeta);
            Subscriber.SendMeasurements(m_unmapper.Unmap(algorithmOutput.OutputData, algorithmOutput.OutputMeta));
        }

        private LVC118.Model.LVC118Data.Inputs CreateLVC118DataInputs(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            LVC118.Model.LVC118Data.Inputs obj = new LVC118.Model.LVC118Data.Inputs();

            {
                // Assign short value to "StateTxTapV" field
                FieldMapping fieldMapping = fieldLookup["StateTxTapV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateTxTapV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSn1CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn1CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSn1CapBkrV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSn2CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn2CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSn2CapBkrV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSn1BusBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn1BusBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSn1BusBkrV = (short)measurement.Value;
            }

            {
                // Assign short value to "StateSn2BusBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn2BusBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSn2BusBkrV = (short)measurement.Value;
            }

            {
                // Assign double value to "MeasTxVoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxVoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasTxVoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasSn1VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasSn1VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasSn1VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasSn2VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasSn2VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasSn2VoltV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasTxMwV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxMwV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasTxMwV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasTxMvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxMvrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasTxMvrV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasGn1MwV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn1MwV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasGn1MwV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasGn1MvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn1MvrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasGn1MvrV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasGn2MwV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn2MwV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasGn2MwV = (double)measurement.Value;
            }

            {
                // Assign double value to "MeasGn2MvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn2MvrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasGn2MvrV = (double)measurement.Value;
            }

            return obj;
        }

        private LVC118.Model.LVC118Data._InputsMeta CreateLVC118Data_InputsMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            LVC118.Model.LVC118Data._InputsMeta obj = new LVC118.Model.LVC118Data._InputsMeta();

            {
                // Assign MetaValues value to "StateTxTapV" field
                FieldMapping fieldMapping = fieldLookup["StateTxTapV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateTxTapV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSn1CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn1CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSn1CapBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSn2CapBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn2CapBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSn2CapBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSn1BusBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn1BusBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSn1BusBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "StateSn2BusBkrV" field
                FieldMapping fieldMapping = fieldLookup["StateSn2BusBkrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.StateSn2BusBkrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasTxVoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxVoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasTxVoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasSn1VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasSn1VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasSn1VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasSn2VoltV" field
                FieldMapping fieldMapping = fieldLookup["MeasSn2VoltV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasSn2VoltV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasTxMwV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxMwV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasTxMwV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasTxMvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasTxMvrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasTxMvrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasGn1MwV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn1MwV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasGn1MwV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasGn1MvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn1MvrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasGn1MvrV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasGn2MwV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn2MwV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasGn2MwV = GetMetaValues(measurement);
            }

            {
                // Assign MetaValues value to "MeasGn2MvrV" field
                FieldMapping fieldMapping = fieldLookup["MeasGn2MvrV"];
                IMeasurement measurement = GetMeasurement(fieldMapping);
                obj.MeasGn2MvrV = GetMetaValues(measurement);
            }

            return obj;
        }

        #endregion
    }
}
