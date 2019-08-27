using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class TypeUnitValueAttr
    {

        [XmlAttribute("xsi_type")]
        public string type { get; set; }

        [XmlAttribute()]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string unit { get; set; }
    }
}
