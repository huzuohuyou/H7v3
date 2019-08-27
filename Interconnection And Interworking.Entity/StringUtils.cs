using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterconnectionAndInterworking.Entity
{

    public static class StringUtils
    {
        public static string SubString(this string str, int length)
        {
            if ((str??"").Length > length)
            {
                return str.Substring(0, length);
            }
            return str;
        }
    }
}
