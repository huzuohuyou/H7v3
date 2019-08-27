using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AddrState
    {

        /// <remarks/>
        [XmlAttribute()]
        public string language { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }
}
