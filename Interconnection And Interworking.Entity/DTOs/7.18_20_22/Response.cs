using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._18_20_22
{
    /// <summary>
    /// * Author: 吴海龙
    /// * CreatedTime: 2019/3/29 10:09:57
    /// * Description: 门诊，住院，出院【注册】响应模型
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = false)]
    public partial class Response :TypeCodeAttr, IContent
    {
        /// <remarks/>
        public acknowledgementTargetMessage targetMessage { get; set; }

        /// <remarks/>
        public acknowledgementAcknowledgementDetail acknowledgementDetail { get; set; }
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class acknowledgementTargetMessage
    {
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }
    }

    /// <remarks/>
    //[Serializable]
    //[DesignerCategory("code")]
    //[XmlType(AnonymousType = true)]
    //public partial class acknowledgementAcknowledgementDetail
    //{
    //    /// <remarks/>
    //    public string text { get; set; }
    //}


    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class acknowledgementAcknowledgementDetail
    {

        /// <remarks/>
        public string text { get; set; }
    }


}
