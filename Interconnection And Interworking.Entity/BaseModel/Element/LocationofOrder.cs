using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class LocationofOrder : TypeCodeAttr
    {

        /// <remarks/>
        public string time { get; set; }

        /// <remarks/>
        public ServiceDeliveryLocation serviceDeliveryLocation { get; set; }

    }
}
