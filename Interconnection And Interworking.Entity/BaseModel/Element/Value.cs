using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using App.FunctionLibrary;

namespace InterconnectionAndInterworking.Entity
{

    public class Value:ValueAttr
    {
        [XmlIgnore]
        public DateTime? DateTime
        {
            get
            {
                value = value.PadRight(14, '0');
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

        }

    }
}
