using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Author : TypeContextControlAttr
    {
        /// <summary>
        /// 时间值节点
        /// </summary>
        public Value time { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public Code signatureCode { get; set; }
        /// <summary>
        /// 文本
        /// </summary>
        public string signatureText { get; set; }
        /// <remarks/>
        public AssignedEntity assignedEntity { get; set; }


    }
}
