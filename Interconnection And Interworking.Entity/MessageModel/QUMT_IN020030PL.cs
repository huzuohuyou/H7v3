using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._15;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 医嘱查询
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class QUMT_IN020030PL : BaseRequest<Request>
    {
    }
}
