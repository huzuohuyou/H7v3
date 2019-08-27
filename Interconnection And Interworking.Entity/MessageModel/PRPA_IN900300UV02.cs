using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._19_21_23;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// * Description: 门诊、住院、出院 就诊通用查询服务
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPA_IN900300UV02 : BaseRequest<Request>
    {
        
    }
}
