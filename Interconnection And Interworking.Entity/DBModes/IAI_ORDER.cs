using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterconnectionAndInterworking.Entity.DBModes
{

    [SugarTable("IAI_ORDER")]
    public class IAI_ORDER
    {
        public string order_id { get; set; }
        public string order_type_code { get; set; }
        public string text { get; set; }
        public string effectivetime_high { get; set; }
        public string effectivetime_low { get; set; }
        public string effectivetime_period { get; set; }
        public string effectivetime_unit { get; set; }
        public string route_code { get; set; }
        public string dose_quantity { get; set; }
        public string dose_quantity_unit { get; set; }
        public string numertor { get; set; }
        public string denominator { get; set; }
        
        public string unit_code { get; set; }
        public string medicine_name { get; set; }
        public string capacity_quantity { get; set; }
        public string patient_id { get; set; }
        public string author_time { get; set; }
        public string signature_text { get; set; }
        public string assignedentity_id { get; set; }
        public string assignedperson_name { get; set; }
        public string organization_id { get; set; }
        public string organization_name { get; set; }
        public string verifier_time { get; set; }
        public string verifier_assignedentity_id { get; set; }
        public string verifier_assignedentity_name { get; set; }
        public string annotion_text { get; set; }
        public string annotion_status_code { get; set; }
        public string annotion_author_id { get; set; }
        public string annotion_author_name { get; set; }
        public string annotion_organization_id { get; set; }
        public string annotion_organization_name { get; set; }
        public string encounter_id { get; set; }

    }
}
