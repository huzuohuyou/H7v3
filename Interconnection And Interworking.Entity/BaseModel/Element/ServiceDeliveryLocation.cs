using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ServiceDeliveryLocation : ClassCodeAttr
    {

        /// <remarks/>
        public ServiceDeliveryLocationLocation location { get; set; }

        /// <remarks/>
        public ServiceProviderOrganization serviceProviderOrganization { get; set; }

    }
}
