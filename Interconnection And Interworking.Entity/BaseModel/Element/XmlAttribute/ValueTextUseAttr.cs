using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ValueTextUseAttr
    {
        /// <remarks/>
        [XmlText]
        public string value { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string use { get; set; }
    }
}
