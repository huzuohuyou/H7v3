using SqlSugar;

namespace InterconnectionAndInterworking.Entity.DBModes
{
    [SugarTable("IAI_MEDICAL_REGISTRATION")]
    public class IAI_MEDICAL_REGISTRATION
    {
       public string encounterevent_id {get;set;}
        public string type_code { get;set;}
        public string effective_time { get;set;}
        public string original_text { get;set;}
        public string patient_id { get;set;}
        public string patient_name { get;set;}
        public string consultant_id { get;set;}
        public string consultant_name { get;set;}
        public string location_id { get;set;}
        public string location_name { get;set;}
        public string organization_id { get;set;}
        public int medical_type { get;set;}
    }
}
