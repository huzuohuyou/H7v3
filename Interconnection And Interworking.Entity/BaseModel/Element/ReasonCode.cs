using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ReasonCode
    {
        /// <summary />
        public string originalText { get; set; }
    }
}
