using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._14;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 医嘱接收
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class POOR_IN200901UV : BaseRequest<Request>
    {
    }
}
