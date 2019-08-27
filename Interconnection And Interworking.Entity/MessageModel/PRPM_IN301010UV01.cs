using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._5;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 新增医护人员注册服务
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPM_IN301010UV01 : BaseRequest<Request>
    {
    }
}
