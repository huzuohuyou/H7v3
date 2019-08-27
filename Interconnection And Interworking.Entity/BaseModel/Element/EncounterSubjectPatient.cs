using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class EncounterSubjectPatient : ClassCodeAttr
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public IDwithRootExtendsion[] id { get; set; }

        /// <remarks/>
        public Telecom telecom { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public PatientPerson<AsOtherIDsofOrder> patientPerson { get; set; }


    }
}
