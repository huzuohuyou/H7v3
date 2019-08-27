using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class EncounterSubject : TypeCodeAttr
    {

        /// <remarks/>
        public EncounterSubjectPatient patient { get; set; }

    }
}
