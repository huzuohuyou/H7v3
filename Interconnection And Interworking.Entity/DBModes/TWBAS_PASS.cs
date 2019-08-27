using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;

namespace InterconnectionAndInterworking.Entity.DBModes
{
    [SugarTable("TWBAS_PASS")]
    public class TWBAS_PASS
    {
        public string idnumber { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string jobgroup { get; set; }
        public string jobgrade { get; set; }
        public string part { get; set; }
        public string buse { get; set; }
        public string deptcode { get; set; }
        public string drcode { get; set; }
        public string drgrade { get; set; }
        public int printranking { get; set; }
        public string drdept1 { get; set; }
        public string drdept2 { get; set; }
        public int seqam { get; set; }
        public int seqpm { get; set; }
        public string gbjupsu { get; set; }
        public string gbspc { get; set; }
        public string license { get; set; }
        public string licensespc { get; set; }
        public string telno { get; set; }
        public string email { get; set; }
        public string gbjaejik { get; set; }
        public DateTime? frdate { get; set; }
        public string outdate { get; set; }
        public string remark { get; set; }
        public string drdept3 { get; set; }
        public string drdept4 { get; set; }
        public string drdept5 { get; set; }
        public string drdept6 { get; set; }
        public string gbipd { get; set; }
    }
}
