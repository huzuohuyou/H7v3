using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class QueryByParameterPayload
    {

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public ValueSemanticsText<CodeSystem> administrativeGender { get; set; }

        /// <remarks/>
        public ValueSemanticsText<Value> dOB { get; set; }

        /// <remarks/>
        public ValueSemanticsText<IDwithRootExtendsion> providerID { get; set; }

        /// <remarks/>
        public ValueSemanticsText<string> providerName { get; set; }

        public ValueSemanticsText<ValuewithRootExtension> organizationID { get; set; }

        public ValueSemanticsText<string> organizationName { get; set; }

        public status status { get; set; }
    }


    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class status
    {

        /// <remarks/>
        public statusValue value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class statusValue
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code { get; set; }
    }



}
