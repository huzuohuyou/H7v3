using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Verifier : TypeContextConductionIndAttr
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
