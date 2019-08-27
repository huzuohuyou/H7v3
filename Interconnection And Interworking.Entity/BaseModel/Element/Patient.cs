using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Patient : ClassCodeAttr
    {
        public IDwithRootExtendsion id { get; set; }
        public PatientPerson patientPerson{get;set;}
    }
}
