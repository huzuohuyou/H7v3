using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterconnectionAndInterworking.Entity
{

    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ObservationRequest:ClassMoodAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public string code { get; set; }

        /// <remarks/>
        public string text { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public EffectiveTimewithLowHigh effectiveTime { get; set; }

        /// <remarks/>
        public CodeSystem priorityCode { get; set; }

        /// <remarks/>
        public Specimen specimen { get; set; }

        /// <remarks/>
        public RecordTarget recordTarget { get; set; }

        /// <remarks/>
        public Author author { get; set; }

        /// <remarks/>
        public Author verifier { get; set; }

        /// <remarks/>
        public Goal goal { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reason")]
        public Reason[] reason { get; set; }

        /// <remarks/>
        public SubjectOf6 subjectOf6 { get; set; }

        /// <remarks/>
        public ComponentOf1 componentOf1 { get; set; }


    }



}
