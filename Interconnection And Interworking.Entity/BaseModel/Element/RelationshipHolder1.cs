using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{

    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RelationshipHolder1 : ClassDeterminerAttr
    {

        /// <remarks/>
        public string name { get; set; }


    }
}
