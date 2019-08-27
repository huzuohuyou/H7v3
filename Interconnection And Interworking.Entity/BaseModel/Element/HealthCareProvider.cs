using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class HealthCareProvider : ClassCodeAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public string addr { get; set; }

        /// <remarks/>
        public Telecom telecom { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public EffectiveTimewithLowHigh effectiveTime { get; set; }

        /// <remarks/>
        public HealthCarePrincipalPerson healthCarePrincipalPerson { get; set; }


    }
}
