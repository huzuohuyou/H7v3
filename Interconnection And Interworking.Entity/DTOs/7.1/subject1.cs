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
    public partial class subject1<T> 
    {

        private string typeCodeField;
        private T patientField;

        /// <remarks/>
        [XmlAttribute]
        public string typeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        /// <remarks/>
        
        public T patient
        {
            get
            {
                return this.patientField;
            }
            set
            {
                this.patientField = value;
            }
        }
    }


}
