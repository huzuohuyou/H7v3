using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ValueUseAttr
    {
        /// <remarks/>
        [XmlAttribute]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string use { get; set; }
    }
}
