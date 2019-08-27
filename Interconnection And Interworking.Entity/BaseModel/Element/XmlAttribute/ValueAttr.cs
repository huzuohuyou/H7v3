using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    public class ValueAttr
    {
        [XmlAttribute()]
        public string value { get; set; }
    }
}
