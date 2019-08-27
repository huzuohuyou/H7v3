using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.Acknowledgement.InOutandDischarge.Failure
{
    /// <summary>
    /// * Author: 吴海龙
    /// * CreatedTime: 2019/4/1 14:36:14
    /// * Description: 门诊，住院，出院【查询】响应模型
    /// </summary>
    /// 
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class AckQueryResponsePart : IContent
    {
        /// <remarks/>
        public acknowledgementTargetMessage targetMessage { get; set; }

        /// <remarks/>
        public acknowledgementAcknowledgementDetail acknowledgementDetail { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string typeCode { get; set; }
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
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class acknowledgementAcknowledgementDetail
    {
        /// <remarks/>
        public string text { get; set; }
    }
}
