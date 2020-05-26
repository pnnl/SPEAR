﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// DELETE ME

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 

namespace SPEAR.Models.Schemas.AtomTex
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class N42InstrumentData
    {
        private Measurement[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Measurement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Measurement[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Measurement
    {

        private string remarkField;

        private CountDoseData[] countDoseDataField;

        private InstrumentInformation[] instrumentInformationField;

        private MeasuredItemInformationCoordinates[] measuredItemInformationField;

        private NuclideAnalysis[] analysisResultsField;

        private Spectrum[] spectrumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Remark
        {
            get
            {
                return this.remarkField;
            }
            set
            {
                this.remarkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CountDoseData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CountDoseData[] CountDoseData
        {
            get
            {
                return this.countDoseDataField;
            }
            set
            {
                this.countDoseDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstrumentInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InstrumentInformation[] InstrumentInformation
        {
            get
            {
                return this.instrumentInformationField;
            }
            set
            {
                this.instrumentInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Coordinates", typeof(MeasuredItemInformationCoordinates), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MeasuredItemInformationCoordinates[] MeasuredItemInformation
        {
            get
            {
                return this.measuredItemInformationField;
            }
            set
            {
                this.measuredItemInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("NuclideAnalysis", typeof(NuclideAnalysis), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public NuclideAnalysis[] AnalysisResults
        {
            get
            {
                return this.analysisResultsField;
            }
            set
            {
                this.analysisResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Spectrum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Spectrum[] Spectrum
        {
            get
            {
                return this.spectrumField;
            }
            set
            {
                this.spectrumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CountDoseData
    {

        private N42InstrumentDataMeasurementCountDoseDataDoseRate[] doseRateField;

        private N42InstrumentDataMeasurementCountDoseDataCountRate[] countRateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DoseRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public N42InstrumentDataMeasurementCountDoseDataDoseRate[] DoseRate
        {
            get
            {
                return this.doseRateField;
            }
            set
            {
                this.doseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CountRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public N42InstrumentDataMeasurementCountDoseDataCountRate[] CountRate
        {
            get
            {
                return this.countRateField;
            }
            set
            {
                this.countRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class N42InstrumentDataMeasurementCountDoseDataDoseRate
    {

        private string unitsField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class N42InstrumentDataMeasurementCountDoseDataCountRate
    {

        private string unitsField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InstrumentInformation
    {

        private string instrumentTypeField;

        private string instrumentModelField;

        private string instrumentVersionField;

        private string manufacturerField;

        private string instrumentIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InstrumentType
        {
            get
            {
                return this.instrumentTypeField;
            }
            set
            {
                this.instrumentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InstrumentModel
        {
            get
            {
                return this.instrumentModelField;
            }
            set
            {
                this.instrumentModelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InstrumentVersion
        {
            get
            {
                return this.instrumentVersionField;
            }
            set
            {
                this.instrumentVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InstrumentID
        {
            get
            {
                return this.instrumentIDField;
            }
            set
            {
                this.instrumentIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MeasuredItemInformationCoordinates
    {

        private string timeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NuclideAnalysis
    {

        private Nuclide[] nuclideField;

        private string algorithmDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Nuclide", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Nuclide[] Nuclide
        {
            get
            {
                return this.nuclideField;
            }
            set
            {
                this.nuclideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AlgorithmDescription
        {
            get
            {
                return this.algorithmDescriptionField;
            }
            set
            {
                this.algorithmDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Nuclide
    {

        private string nuclideTypeField;

        private string nuclideNameField;

        private string nuclideIDConfidenceIndicationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NuclideType
        {
            get
            {
                return this.nuclideTypeField;
            }
            set
            {
                this.nuclideTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NuclideName
        {
            get
            {
                return this.nuclideNameField;
            }
            set
            {
                this.nuclideNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NuclideIDConfidenceIndication
        {
            get
            {
                return this.nuclideIDConfidenceIndicationField;
            }
            set
            {
                this.nuclideIDConfidenceIndicationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Spectrum
    {

        private string liveTimeField;

        private string detectorTypeField;

        private string realTimeField;

        private string rASE_SensitivityField;

        private N42InstrumentDataMeasurementSpectrumCalibration[] calibrationField;

        private N42InstrumentDataMeasurementSpectrumChannelData[] channelDataField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LiveTime
        {
            get
            {
                return this.liveTimeField;
            }
            set
            {
                this.liveTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DetectorType
        {
            get
            {
                return this.detectorTypeField;
            }
            set
            {
                this.detectorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RealTime
        {
            get
            {
                return this.realTimeField;
            }
            set
            {
                this.realTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RASE_Sensitivity
        {
            get
            {
                return this.rASE_SensitivityField;
            }
            set
            {
                this.rASE_SensitivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Calibration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public N42InstrumentDataMeasurementSpectrumCalibration[] Calibration
        {
            get
            {
                return this.calibrationField;
            }
            set
            {
                this.calibrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChannelData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public N42InstrumentDataMeasurementSpectrumChannelData[] ChannelData
        {
            get
            {
                return this.channelDataField;
            }
            set
            {
                this.channelDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class N42InstrumentDataMeasurementSpectrumCalibration
    {

        private N42InstrumentDataMeasurementSpectrumCalibrationArrayXY[] arrayXYField;

        private string typeField;

        private string energyUnitsField;

        private string fWHMUnitsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrayXY", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public N42InstrumentDataMeasurementSpectrumCalibrationArrayXY[] ArrayXY
        {
            get
            {
                return this.arrayXYField;
            }
            set
            {
                this.arrayXYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EnergyUnits
        {
            get
            {
                return this.energyUnitsField;
            }
            set
            {
                this.energyUnitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FWHMUnits
        {
            get
            {
                return this.fWHMUnitsField;
            }
            set
            {
                this.fWHMUnitsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class N42InstrumentDataMeasurementSpectrumCalibrationArrayXY
    {

        private N42InstrumentDataMeasurementSpectrumCalibrationArrayXYPointXY[] pointXYField;

        private string xField;

        private string yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointXY", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public N42InstrumentDataMeasurementSpectrumCalibrationArrayXYPointXY[] PointXY
        {
            get
            {
                return this.pointXYField;
            }
            set
            {
                this.pointXYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class N42InstrumentDataMeasurementSpectrumCalibrationArrayXYPointXY
    {

        private string xField;

        private string yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class N42InstrumentDataMeasurementSpectrumChannelData
    {

        private string compressionField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Compression
        {
            get
            {
                return this.compressionField;
            }
            set
            {
                this.compressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}