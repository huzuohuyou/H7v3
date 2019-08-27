using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{


    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AsAffiliate
    {

        /// <remarks/>
        public string code { get; set; }

        /// <remarks/>
        public EffectiveTime effectiveTime { get; set; }

        /// <remarks/>
        public AffiliatedPrincipalOrganization affiliatedPrincipalOrganization { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string classCode { get; set; }
    }
}
