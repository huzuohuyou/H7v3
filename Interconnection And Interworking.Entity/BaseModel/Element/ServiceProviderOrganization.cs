using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{


    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ServiceProviderOrganization : ClassDeterminerAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public string name { get; set; }

        /// <remarks/>
        public AsOrganizationPartOf2 asOrganizationPartOf { get; set; }


    }
}
