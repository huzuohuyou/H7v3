using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SubstanceAdministrationRequestAuthor : TypeContextControlAttr
    {

        /// <remarks/>
        public Value time { get; set; }

        /// <remarks/>
        public Code signatureCode { get; set; }

        /// <remarks/>
        public string signatureText { get; set; }

        /// <remarks/>
        public AssignedEntity assignedEntity { get; set; }


    }
}
