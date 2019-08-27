using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AsEmployee : ClassCodeAttr
    {

        /// <remarks/>
        public CodeSystem occupationCode { get; set; }

        /// <remarks/>
        public EmployerOrganization employerOrganization { get; set; }


    }
}
