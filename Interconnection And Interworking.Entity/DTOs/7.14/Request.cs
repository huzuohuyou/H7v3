using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._14
{

    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Request :ClassMoodAttr, IContent
    {

        /// <remarks/>
        public CodeSystem code { get; set; }
        /// <remarks/>
        public controlActProcessSubject subject { get; set; }

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class controlActProcessSubject:TypeCodeAttr
    {

        /// <remarks/>
        public AdministrationRequest substanceAdministrationRequest { get; set; }

        public ObservationRequest observationRequest { get; set; }
    }

   

}
