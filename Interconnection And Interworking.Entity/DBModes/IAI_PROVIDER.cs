using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterconnectionAndInterworking.Entity.DBModes
{
    [SugarTable("IAI_PROVIDER")]
    public class IAI_PROVIDER
    {
        public string healthcareprovider_id { get; set; }
        public string healthcareprovider_code { get; set; }
        public string effectivetime_high { get; set; }
        public string effectivetime_low { get; set; }
        public string id_number { get; set; }
        public string name { get; set; }
        public string gender_code { get; set; }
        public string birth_time { get; set; }
        public string organization_id { get; set; }
        public string organization_name { get; set; }
        public string birth_place { get; set; }
    }
}
