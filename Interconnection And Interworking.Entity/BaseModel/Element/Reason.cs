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
    public partial class Reason : TypeContextConductionIndAttr
    {

        /// <remarks/>
        public Observation observation { get; set; }

        


    }




    
}
