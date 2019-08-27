using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._4
{

    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Request:ClassMoodAttr, IContent
    {

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public controlActProcessQueryByParameter queryByParameter { get; set; }


    }


    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryByParameter
    {

        /// <remarks/>
        public IDwithRootExtendsion queryId { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public Value initialQuantity { get; set; }

        /// <remarks/>
        public controlActProcessQueryByParameterMatchCriterionList matchCriterionList { get; set; }

        /// <remarks/>
        public controlActProcessQueryByParameterParameterList parameterList { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryByParameterQueryId
    {

        private string rootField;

        private string extensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string root
        {
            get
            {
                return this.rootField;
            }
            set
            {
                this.rootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }



    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryByParameterMatchCriterionList
    {

        /// <remarks/>
        public controlActProcessQueryByParameterMatchCriterionListMinimumDegreeMatch minimumDegreeMatch { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryByParameterMatchCriterionListMinimumDegreeMatch
    {

        /// <remarks/>
        //public value value { get; set; }

        /// <remarks/>
        public string semanticsText { get; set; }
    }

    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class value
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public byte value1 { get; set; }
    }






    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryByParameterParameterList
    {

        /// <remarks/>
        public controlActProcessQueryByParameterParameterListLivingSubjectId livingSubjectId { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryByParameterParameterListLivingSubjectId
    {

        /// <remarks/>
        public IDwithRootExtendsion value { get; set; }

        /// <remarks/>
        public string semanticsText { get; set; }
    }





}
