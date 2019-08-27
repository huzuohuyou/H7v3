using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._7;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 医护人员信息查询服务
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPM_IN306010UV01 : BaseRequest<Request>
    {
    }
}
