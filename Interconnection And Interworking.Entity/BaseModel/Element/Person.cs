using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <summary>
    /// 包含classCode 和 determinerCode
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Person : ClassDeterminerAttr
    {
        /// <remarks/>
        public Name name { get; set; }
    }

    
}
