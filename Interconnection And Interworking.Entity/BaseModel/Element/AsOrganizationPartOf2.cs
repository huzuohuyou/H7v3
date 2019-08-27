using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AsOrganizationPartOf2 : ClassCodeAttr
    {

        /// <remarks/>
        public WholeOrganization wholeOrganization { get; set; }


    }
}
