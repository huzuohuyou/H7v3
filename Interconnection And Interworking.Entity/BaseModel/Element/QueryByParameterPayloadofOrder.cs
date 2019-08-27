using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class QueryByParameterPayloadofOrder
    {

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public ValueSemanticsText<ValuewithRootExtension> actId { get; set; }

        /// <remarks/>
        public ValueSemanticsText<ValuewithRootExtension> authorId { get; set; }

        /// <remarks/>
        public ValueSemanticsText<EffectiveTimewithLowHigh> effectiveTime { get; set; }

        /// <remarks/>
        public ValueSemanticsText<ValuewithRootExtension> patientId { get; set; }

        /// <remarks/>
        public ValueSemanticsText<ValuewithCode> statusCodeParam { get; set; }
    }

}
