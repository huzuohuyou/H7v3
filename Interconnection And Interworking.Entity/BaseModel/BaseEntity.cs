// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class BaseEntity : IBaseEntity 
    {
       
        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public Time creationTime { get; set; }

        /// <remarks/>
        public IDwithRootExtendsion interactionId { get; set; }

        /// <remarks/>
        public Code processingCode { get; set; }

        /// <remarks/>
        public Code processingModeCode { get; set; }

        /// <remarks/>
        public Code acceptAckCode { get; set; }

        /// <remarks/>
        public SendReceiver receiver { get; set; }

        /// <remarks/>
        public SendReceiver sender { get; set; }
    }
}