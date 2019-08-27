using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ContainerPackagedMedicine : ClassDeterminerAttr
    {

        /// <remarks/>
        public ValueUnit capacityQuantity { get; set; }


    }
}
