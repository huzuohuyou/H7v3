using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._9;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 卫生机构更新请求
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPM_IN403010UV01 : BaseRequest<Request>
    {
    }
}
