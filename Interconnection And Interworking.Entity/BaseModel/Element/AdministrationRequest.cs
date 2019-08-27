using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AdministrationRequest : ClassMoodAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public string text { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        [XmlElement("effectiveTime")]
        public EffectiveTimewithLowHigh[] effectiveTime { get; set; }

        /// <remarks/>
        public CodeSystem routeCode { get; set; }

        /// <remarks/>
        public ValueUnit doseQuantity { get; set; }

        /// <remarks/>
        public DoseCheckQuantity doseCheckQuantity { get; set; }

        /// <remarks/>
        public CodeSystem administrationUnitCode { get; set; }

        /// <remarks/>
        public Consumable2 consumable2 { get; set; }

        /// <remarks/>
        public Author author { get; set; }

        /// <remarks/>
        public Author verifier { get; set; }

        /// <remarks/>
        public SubjectOf6 subjectOf6 { get; set; }

        /// <remarks/>
        public ComponentOf1 componentOf1 { get; set; }


    }
}
