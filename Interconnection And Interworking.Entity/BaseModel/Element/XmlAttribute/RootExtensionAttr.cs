using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class RootExtensionAttr
    {
        /// <remarks/>
        [XmlAttribute()]
        public string root { get; set; }

        /// <remarks/>
       
        private string _extension;
        [XmlAttribute()]
        public string extension
        {
            get
            {
                if (_extension == null || _extension == "")
                {
                    return Guid.NewGuid().ToString();
                }
                return _extension;

            }
            set
            {
                _extension = value;
            }
        }
    }
}
