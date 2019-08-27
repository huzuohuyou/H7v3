using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._18;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// * Description: 门诊就诊登记服务序列化实体类
    /// * 对应文件：EMR-PL-27门诊就诊登记服务-F01-患者尚未注册.xml
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
    //[XmlRoot(Namespace = "", IsNullable = false, ElementName = "PRPA_IN401001UV02")]
    public class PRPA_IN401001UV02 : BaseRequest<Request>
    {
    }
}
