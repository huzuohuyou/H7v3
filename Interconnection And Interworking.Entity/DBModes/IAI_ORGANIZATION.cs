using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterconnectionAndInterworking.Entity.DBModes
{
    [SugarTable("IAI_ORGANIZATION")]
    public class IAI_ORGANIZATION
    {
        public string organization_id { get; set; }
        public string organization_code { get; set; }
        public string role_name { get; set; }
        public string addr { get; set; }
        public string telecom { get; set; }
        public string effectivetime_high { get; set; }
        public string effectivetime_low { get; set; }
        public string name { get; set; }
        public string scoper2_id { get; set; }
        public string scoper2_name { get; set; }

    }
}
