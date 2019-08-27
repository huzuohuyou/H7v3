using SqlSugar;

namespace InterconnectionAndInterworking.Entity.DBModes
{
    [SugarTable("IAI_OBSERVATION")]
    public class IAI_OBSERVATION
    {
        public string observation_id { get; set; }
        public string observation_type  { get; set; }
        public string observation_text  { get; set; }
        public string effectivetime_high  { get; set; }
        public string effectivetime_low  { get; set; }
        public string prioritycode { get; set; }
        public string specimen_id { get; set; }
        public string specimen_code { get; set; }
        public string specimen_desc { get; set; }
        public string additive3 { get; set; }
        public string productOf_time { get; set; }
        public string specimenProcessStep_time { get; set; }
        
        public string recordtarget { get; set; }
        public string author_time { get; set; }
        public string signaturetext { get; set; }
        public string author_assignedentity_id { get; set; }
        public string assignedperson_name { get; set; }
        public string representedorganization_id { get; set; }
        public string representedorganization_name { get; set; }
        public string verifier_time { get; set; }
        public string verifier_signaturetext { get; set; }
        public string verifier_assignedentity_id { get; set; }
        public string verifier_assignedperson_name  { get; set; }
        public string goal_text  { get; set; }
        public string goal_reason  { get; set; }
        public string annotation_text  { get; set; }
        public string annotation_author_id { get; set; }
        public string annotation_author_name  { get; set; }
        public string represented_organization_id  { get; set; }
        public string represented_organization_name { get; set; }
        public string encounter_id { get; set; }
    }
}
