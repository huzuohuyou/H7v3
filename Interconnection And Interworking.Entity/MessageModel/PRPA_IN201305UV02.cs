using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._4;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 个人基本信息查询服务
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPA_IN201305UV02 : BaseRequest<Request>
    {
    }
}
