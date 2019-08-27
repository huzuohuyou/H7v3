using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class CommonAcknowledgement:TypeCodeAttr, IContent
    {
        public bool Success
        {
            get
            {
                if (typeCodeField == "AA")
                {
                    return true;
                }
                return false;
            }
        }
        private string typeCodeField;

        /// <remarks/>
        public CommonTargetMessage targetMessage { get; set; }

        /// <remarks/>
        public CommonAcknowledgementDetail acknowledgementDetail { get; set; }
        public CommonAcknowledgement():this(true, "", "", "") { }
        public CommonAcknowledgement(string root, string extension):this(true, root, extension, "成功")
        {
            
        }

        public CommonAcknowledgement(string root, string extension, string text) : this(false, root, extension, text)
        {

        }

        private CommonAcknowledgement(bool success, string root, string extension, string text)
        {
            typeCode = success ? "AA" : "AE";
            targetMessage = new CommonTargetMessage
            {
                id = new IDwithRootExtendsion
                {
                    root = root,
                    extension = extension,
                }
            };
            if (text!="")
            {
                acknowledgementDetail = new CommonAcknowledgementDetail
                {
                    text = text
                };
            }
            
        }

    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class CommonTargetMessage
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class acknowledgementTargetMessageID:RootExtensionAttr
    {

        
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class CommonAcknowledgementDetail
    {

        /// <remarks/>
        public string text { get; set; }
    }


}
