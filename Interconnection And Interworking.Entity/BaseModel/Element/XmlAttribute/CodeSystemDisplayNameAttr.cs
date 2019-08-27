using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class CodeSystemDisplayNameAttr : CodeAttr
    {
        public CodeSystemDisplayNameAttr() { }

        public CodeSystemDisplayNameAttr(string codeSystem, string code, string displayName)
        {
            code = code;
            codeSystem = codeSystem;
            displayName = displayName;
        }
        /// <remarks/>
        [XmlAttribute]
        public string codeSystem { get; set; }

        private string _displayName;
        /// <remarks/>
        [XmlAttribute]
        public string displayName
        {
            get
            {
                if (_displayName == null
                    || _displayName == ""
                    || codeSystem == "2.16.156.10011.2.3.3.4"
                    || codeSystem == "2.16.156.10011.2.3.3.5"
                    || codeSystem == "2.16.156.10011.2.3.3.3"
                    || codeSystem == "2.16.156.10011.2.3.1.271")
                {
                    return GetDisplayName(codeSystem, code);
                }
                return _displayName;
            }
            set { _displayName = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public string codeSystemName { get; set; }

        public static string GetDisplayName(string codeSystem, string code = "")
        {
            if (dictnory.Keys.ToList().Contains(codeSystem) && dictnory[codeSystem].Keys.ToList().Contains(code))
            {
                return dictnory[codeSystem][code];
            }
            return "未查匹配到字典";
        }

        private static Dictionary<string,  Dictionary<string, string>> dictnory = new Dictionary<string,  Dictionary<string, string>>
        {
            {"2.16.156.10011.2.3.3.4",
                new Dictionary<string, string>{
                 { "0","未知的性别"}
                ,{ "1","男性"}
                ,{ "2","女性"}
                ,{ "9","未说明性别"} }
            },

            {"2.16.156.10011.2.3.1.271",
                new Dictionary<string, string>{
                 { "1","门诊"}
                ,{ "2","急诊"}
                ,{ "3","住院"}
                ,{ "9","其他"} }
            },

            {"2.16.156.10011.2.3.3.5", 
                new Dictionary<string, string>{
                 { "10","未婚"}
                ,{ "20","已婚"}
                ,{ "21","初婚"}
                ,{ "22","再婚"}
                ,{ "23","复婚"}
                ,{ "30","丧偶"}
                ,{ "40","离婚"}
                ,{ "90","未说明的婚姻状况"}}
            },

            {"2.16.156.10011.2.3.3.3", 
                new Dictionary<string, string>{
                 { "01","汉族"}
                ,{ "02","蒙古族"}
                ,{ "03","回族"}
                ,{ "04","藏族"}
                ,{ "05","维吾尔族"}
                ,{ "06","苗族"}
                ,{ "07","彝族"}
                ,{ "08","壮族"}
                ,{ "09","布依族"}
                ,{ "10","朝鲜族"}
                ,{ "11","满族"}
                ,{ "12","侗族"}
                ,{ "13","瑶族"}
                ,{ "14","白族"}
                ,{ "15","土家族"}
                ,{ "16","哈尼族"}
                ,{ "17","哈萨克族"}
                ,{ "18","傣族"}
                ,{ "19","黎族"}
                ,{ "20","傈僳族"}
                ,{ "21","佤族"}
                ,{ "22","畲族"}
                ,{ "23","高山族"}
                ,{ "24","拉祜族"}
                ,{ "25","水族"}
                ,{ "26","东乡族"}
                ,{ "27","纳西族"}
                ,{ "28","景颇族"}
                ,{ "29","柯尔克孜族"}
                ,{ "30","土族"}
                ,{ "31","达斡尔族"}
                ,{ "32","仫佬族"}
                ,{ "33","羌族"}
                ,{ "34","布朗族"}
                ,{ "35","撒拉族"}
                ,{ "36","毛难族"}
                ,{ "37","仡佬族"}
                ,{ "38","锡伯族"}
                ,{ "39","阿昌族"}
                ,{ "40","普米族"}
                ,{ "41","塔吉克族"}
                ,{ "42","怒族"}
                ,{ "43","乌孜别克族"}
                ,{ "44","俄罗斯族"}
                ,{ "45","鄂温克族"}
                ,{ "46","德昂族"}
                ,{ "47","保安族"}
                ,{ "48","裕固族"}
                ,{ "49","京族"}
                ,{ "50","塔塔尔族"}
                ,{ "51","独龙族"}
                ,{ "52","鄂伦春族"}
                ,{ "53","赫哲族"}
                ,{ "54","门巴族"}
                ,{ "55","珞巴族"}
                ,{ "56","基诺族"}
                }
            },


        };
    }


}
