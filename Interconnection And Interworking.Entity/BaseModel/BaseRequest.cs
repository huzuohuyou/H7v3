// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。

using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class BaseRequest<T> : BaseEntity, IBaseEntity
    {

        /// <remarks/>
        public T controlActProcess { get; set; }

        /// <remarks/>
        /// 
        [XmlElement("acknowledgement", IsNullable = false)]
        public T acknowledgement { get; set; }
    }

    
}