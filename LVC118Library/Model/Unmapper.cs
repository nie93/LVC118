// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System;
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
    public class Unmapper : UnmapperBase
    {
        #region [ Constructors ]

        public Unmapper(Framework framework, MappingCompiler mappingCompiler)
            : base(framework, mappingCompiler, SystemSettings.OutputMapping)
        {
            Algorithm.Output.CreateNew = () => new Algorithm.Output()
            {
                OutputData = FillOutputData(),
                OutputMeta = FillOutputMeta()
            };
        }

        #endregion

        #region [ Methods ]

        public LVC118.Model.LVC118Data.Outputs FillOutputData()
        {
            TypeMapping outputMapping = MappingCompiler.GetTypeMapping(OutputMapping);
            Reset();
            return FillLVC118DataOutputs(outputMapping);
        }

        public LVC118.Model.LVC118Data._OutputsMeta FillOutputMeta()
        {
            TypeMapping outputMeta = MappingCompiler.GetTypeMapping(OutputMapping);
            Reset();
            return FillLVC118Data_OutputsMeta(outputMeta);
        }

        public IEnumerable<IMeasurement> Unmap(LVC118.Model.LVC118Data.Outputs outputData, LVC118.Model.LVC118Data._OutputsMeta outputMeta)
        {
            List<IMeasurement> measurements = new List<IMeasurement>();
            TypeMapping outputMapping = MappingCompiler.GetTypeMapping(OutputMapping);

            CollectFromLVC118DataOutputs(measurements, outputMapping, outputData, outputMeta);

            return measurements;
        }

        private LVC118.Model.LVC118Data.Outputs FillLVC118DataOutputs(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            LVC118.Model.LVC118Data.Outputs obj = new LVC118.Model.LVC118Data.Outputs();

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            {
                // We don't need to do anything, but we burn a key index to keep our
                // array index in sync with where we are in the data structure
                BurnKeyIndex();
            }

            return obj;
        }

        private LVC118.Model.LVC118Data._OutputsMeta FillLVC118Data_OutputsMeta(TypeMapping typeMapping)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);
            LVC118.Model.LVC118Data._OutputsMeta obj = new LVC118.Model.LVC118Data._OutputsMeta();

            {
                // Initialize meta value structure to "ActTxRaise" field
                FieldMapping fieldMapping = fieldLookup["ActTxRaise"];
                obj.ActTxRaise = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActTxLower" field
                FieldMapping fieldMapping = fieldLookup["ActTxLower"];
                obj.ActTxLower = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSn1Close" field
                FieldMapping fieldMapping = fieldLookup["ActSn1Close"];
                obj.ActSn1Close = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSn1Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSn1Trip"];
                obj.ActSn1Trip = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSn2Close" field
                FieldMapping fieldMapping = fieldLookup["ActSn2Close"];
                obj.ActSn2Close = CreateMetaValues(fieldMapping);
            }

            {
                // Initialize meta value structure to "ActSn2Trip" field
                FieldMapping fieldMapping = fieldLookup["ActSn2Trip"];
                obj.ActSn2Trip = CreateMetaValues(fieldMapping);
            }

            return obj;
        }

        private void CollectFromLVC118DataOutputs(List<IMeasurement> measurements, TypeMapping typeMapping, LVC118.Model.LVC118Data.Outputs data, LVC118.Model.LVC118Data._OutputsMeta meta)
        {
            Dictionary<string, FieldMapping> fieldLookup = typeMapping.FieldMappings.ToDictionary(mapping => mapping.Field.Identifier);

            {
                // Convert value from "ActTxRaise" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActTxRaise"];
                IMeasurement measurement = MakeMeasurement(meta.ActTxRaise, (double)data.ActTxRaise);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActTxLower" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActTxLower"];
                IMeasurement measurement = MakeMeasurement(meta.ActTxLower, (double)data.ActTxLower);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSn1Close" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSn1Close"];
                IMeasurement measurement = MakeMeasurement(meta.ActSn1Close, (double)data.ActSn1Close);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSn1Trip" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSn1Trip"];
                IMeasurement measurement = MakeMeasurement(meta.ActSn1Trip, (double)data.ActSn1Trip);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSn2Close" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSn2Close"];
                IMeasurement measurement = MakeMeasurement(meta.ActSn2Close, (double)data.ActSn2Close);
                measurements.Add(measurement);
            }

            {
                // Convert value from "ActSn2Trip" field to measurement
                FieldMapping fieldMapping = fieldLookup["ActSn2Trip"];
                IMeasurement measurement = MakeMeasurement(meta.ActSn2Trip, (double)data.ActSn2Trip);
                measurements.Add(measurement);
            }
        }

        #endregion
    }
}
