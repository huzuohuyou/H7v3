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
    public partial class SpecimenNatural : ClassDeterminerAttr
    {

        /// <remarks/>
        public string code { get; set; }

        /// <remarks/>
        public string desc { get; set; }

        /// <remarks/>
        public Additive additive { get; set; }


    }
}
