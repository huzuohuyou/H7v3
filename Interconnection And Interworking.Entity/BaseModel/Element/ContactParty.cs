using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ContactParty : ClassCodeAttr
    {

        /// <remarks/>
        public Telecom telecom { get; set; }

        /// <remarks/>
        public Person contactPerson { get; set; }

    }
}
