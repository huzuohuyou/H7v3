using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{


    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ValueSemanticsText<T>
    {

        /// <remarks/>
        public T value { get; set; }

        /// <remarks/>
        public string semanticsText { get; set; }
    }
}
