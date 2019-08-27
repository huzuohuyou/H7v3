using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._2;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 个人信息更新
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    //[XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "PRPA_IN201314UV02")]
    public class PRPA_IN201314UV02 : BaseRequest<Request>
    {
    }
}
