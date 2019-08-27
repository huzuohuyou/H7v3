using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AssignedPrincipalOrganization : ClassDeterminerAttr
    {

        /// <remarks/>
        public string name { get; set; }

        /// <remarks/>
        public AsAffiliateofOrganization asAffiliate { get; set; }


    }
}
