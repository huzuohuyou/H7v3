using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class EffectiveTimewithLowHigh:TypeOperatorAttr
    {
        
        /// <remarks/>
        public Value low { get; set; }

        /// <remarks/>
        public Value high { get; set; }

        public ValueUnit period { get; set; }
    }
}
