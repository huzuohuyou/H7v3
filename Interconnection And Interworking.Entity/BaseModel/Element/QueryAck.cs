using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class QueryAck
    {

        /// <remarks/>
        public IDwithRootExtendsion queryId { get; set; }

        /// <remarks/>
        public Code queryResponseCode { get; set; }
    }
}
