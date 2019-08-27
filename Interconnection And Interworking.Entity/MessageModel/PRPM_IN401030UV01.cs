using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._8;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 新增卫生机构
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPM_IN401030UV01 : BaseRequest<Request>
    {
    }
}
