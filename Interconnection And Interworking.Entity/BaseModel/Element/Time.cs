using System;
using System.ComponentModel;
using System.Xml.Serialization;
using App.FunctionLibrary;

namespace InterconnectionAndInterworking.Entity
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class Time
    {
        /// <remarks/>
        [XmlAttribute()]
        public string value { get; set; }

        /// <summary>
        /// 表示的时间值
        /// </summary>
        [XmlIgnore]
        public DateTime? DateTime
        {
            get
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 14)
                    return null;
                else
                    return new DateTime(value.Left(4).CInt(),
                                        value.SubString(4, 2).CInt(),
                                        value.SubString(6, 2).CInt(),
                                        value.SubString(8, 2).CInt(),
                                        value.SubString(10, 2).CInt(),
                                        value.SubString(12, 2).CInt());
            }
            set
            {
                this.value = (value ?? System.DateTime.MinValue).ToString("yyyyMMddHHmmss");
            }
        }
    }
}
