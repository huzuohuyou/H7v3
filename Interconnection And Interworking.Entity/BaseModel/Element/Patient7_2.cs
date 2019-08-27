using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Patient7_2 : ClassCodeAttr
    {
        public IDwithRootExtendsion id { get; set; }

        public StatusCode statusCode { get; set; }

        public EffectiveTime effectiveTime { get; set; }

        public PatientPerson<string> patientPerson{get;set;}
    }
}
