using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._6;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 医护人员信息更新服务
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPM_IN303010UV01 : BaseRequest<Request>
    {
    }
}
