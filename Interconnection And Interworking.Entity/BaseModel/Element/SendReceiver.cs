﻿using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class SendReceiver:TypeCodeAttr
    {
        /// <remarks/>
        public Device device { get; set; }
    }
}
