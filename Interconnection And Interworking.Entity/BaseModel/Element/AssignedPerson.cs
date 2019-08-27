using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AssignedPerson : ClassCodeAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public Person assignedPerson { get; set; }

        /// <remarks/>
        public RepresentedOrganization representedOrganization { get; set; }


    }
}
