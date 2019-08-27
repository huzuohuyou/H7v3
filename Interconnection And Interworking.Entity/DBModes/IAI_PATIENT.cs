using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterconnectionAndInterworking.Entity.DBModes
{
    [SugarTable("IAI_PATIENT")]
    public class IAI_PATIENT
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string patient_id { get; set; }
        public string id_number { get; set; }
        public string name { get; set; }
        public string telecom { get; set; }
        public string gender_code { get; set; }
        public string birth_time { get; set; }
        public string street_address_line  { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string street_name_base { get; set; }
        public string street_name { get; set; }
        public string house_number { get; set; }
        public string postal_code { get; set; }
        public string marital_status_code { get; set; }
        public string ethnic_group_code { get; set; }
        public string occupation_code  { get; set; }
        public string employerorganization_name { get; set; }
        public string employerorganization_telecom { get; set; }
        public string asotherids_id1 { get; set; }
        public string scopingorganization_id1 { get; set; }
        public string asotherids_id2 { get; set; }
        public string scopingorganization_id2 { get; set; }
        public string personalrelationship_code { get; set; }
        public string personalrelationship_telecom { get; set; }
        public string relationshipholder1_name  { get; set; }
        public string providerorganization_id { get; set; }
        public string providerorganization_name { get; set; }
        public string beneficiary_code { get; set; }
    }
}
