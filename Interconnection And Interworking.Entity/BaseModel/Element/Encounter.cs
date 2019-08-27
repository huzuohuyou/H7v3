using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Encounter : ClassMoodAttr
    {

        /// <remarks/>
        public string id { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public EncounterSubject subject { get; set; }

        /// <remarks/>
        public LocationofOrder location { get; set; }

    }
}
