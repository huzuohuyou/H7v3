using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClassMoodAttr: ClassCodeAttr
    {
        /// <remarks/>
        [XmlAttribute()]
        public string moodCode { get; set; }
    }
}
