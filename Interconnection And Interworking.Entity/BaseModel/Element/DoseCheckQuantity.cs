using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DoseCheckQuantity
    {
        [XmlAttribute("xsi_type")]
        public string type { get; set; }
        /// <remarks/>
        public ValueUnit numerator { get; set; }

        /// <remarks/>
        public ValueUnit denominator { get; set; }


    }
}
