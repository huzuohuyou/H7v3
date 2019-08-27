// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。

using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <summary>
    /// 基础响应模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class BaseResponse<T,U> : BaseEntity, IBaseEntity where T: IContent where U:IContent
    {
        /// <remarks/>
        public T acknowledgement { get; set; }
        /// <remarks/>
        public U controlActProcess { get; set; }

        
    }

    
    

}