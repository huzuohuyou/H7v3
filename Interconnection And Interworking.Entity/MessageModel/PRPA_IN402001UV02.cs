using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._20;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// * Author: 吴海龙
    /// * CreatedTime: 2019/3/29 13:36:48
    /// * Description: 住院登记
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPA_IN402001UV02 : BaseRequest<Request>
    {
    }
}
