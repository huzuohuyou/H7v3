using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class registrationRequest<T>
    {

        private statusCode statusCodeField;

        private subject1<T> subject1Field;

        private author authorField;

        private string classCodeField;

        private string moodCodeField;

        /// <remarks/>
        public statusCode statusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        public subject1<T> subject1
        {
            get
            {
                return this.subject1Field;
            }
            set
            {
                this.subject1Field = value;
            }
        }
        /// <remarks/>
        public author author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }


        /// <remarks/>
        [XmlAttribute]
        public string classCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute]
        public string moodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
            }
        }
    }




}
