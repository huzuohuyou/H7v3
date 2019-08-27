using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class AsOtherIDs : ClassCodeAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public ScopingOrganization scopingOrganization { get; set; }


    }



    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class AsOtherIDsofOrder:ClassCodeAttr
    {

        /// <remarks/>
        [XmlElement("id")]
        public asOtherIDsID[] id { get; set; }

   
    }

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class asOtherIDsID
    {

        /// <remarks/>
        [XmlAttribute()]
        public string root { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string extension { get; set; }
    }






}
