using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DTOs._7._22;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// * Author: 吴海龙
    /// * CreatedTime: 2019/3/29 13:48:08
    /// * Description: 出院登记
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    public class PRPA_IN402003UV02 : BaseRequest<Request>
    {
    }
}
