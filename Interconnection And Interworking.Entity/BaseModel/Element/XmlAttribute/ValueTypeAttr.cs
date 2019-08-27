using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ValueTypeAttr
    {
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string value { get; set; }
    }
}
