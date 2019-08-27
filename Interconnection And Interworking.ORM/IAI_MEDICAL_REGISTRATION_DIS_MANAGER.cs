using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using System;

namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 出院操作orm
    /// </summary>
    public class IAI_MEDICAL_REGISTRATION_DIS_MANAGER : BaseManager<IAI_MEDICAL_REGISTRATION, PRPA_IN402003UV02, dynamic, PRPA_IN900300UV02>
    {
        public override IAI_MEDICAL_REGISTRATION Insert(PRPA_IN402003UV02 item)
        {

            var data = new IAI_MEDICAL_REGISTRATION()
            {
                encounterevent_id = item.controlActProcess?.subject?.encounterEvent?.id?.extension,
                type_code = item.controlActProcess?.subject?.encounterEvent?.code?.code,
                effective_time = item.controlActProcess?.subject?.encounterEvent?.effectiveTime?.value,
                original_text = item.controlActProcess?.subject?.encounterEvent?.dischargeDispositionCode.code,
                patient_id = item.controlActProcess?.subject?.encounterEvent?.subject?.patient?.id.code,
                patient_name = item.controlActProcess?.subject?.encounterEvent?.subject?.patient?.patientPerson?.name.Value,
                consultant_id = item.controlActProcess?.subject?.encounterEvent?.discharger?.assignedPerson?.id?.extension,
                consultant_name = item.controlActProcess?.subject?.encounterEvent?.discharger?.assignedPerson?.assignedPerson?.name?.Value,
                medical_type = (int)EncounterEventTypeCode.DISCHARGE,
            };

            var wb = new WhereBuilder();
            wb.And("encounterevent_id", data.encounterevent_id);
            wb.And("medical_type", data.medical_type);

            var sql = $@"
Select      *
From        IAI_MEDICAL_REGISTRATION
";
            if (DBaser.QueryValue<int>("Select count(*) From IAI_MEDICAL_REGISTRATION", wb)>0)
                throw new Exception($@"主键冲突{data.encounterevent_id}已存在。");

            DBaser.Insert("IAI_MEDICAL_REGISTRATION");
            DBaser["encounterevent_id"] = data.encounterevent_id;
            DBaser["type_code"] = data.type_code;
            DBaser["effective_time"] = data.effective_time;
            DBaser["original_text"] = data.original_text;
            DBaser["patient_id"] = data.patient_id;
            DBaser["patient_name"] = data.patient_name;
            DBaser["consultant_id"] = data.consultant_id;
            DBaser["consultant_name"] = data.consultant_name;
            DBaser["medical_type"] = data.medical_type;
            DBaser.AcceptChanges();

            return data;


        }

        public override IAI_MEDICAL_REGISTRATION Select(PRPA_IN900300UV02 item)
        {
            var wb = new WhereBuilder();
            wb.And("encounterevent_id", item?.controlActProcess?.queryByParameterPayload?.careEventID?.value?.extension, true);
            wb.And("medical_type", EncounterEventTypeCode.DISCHARGE);

            var sql = $@"
Select      *
From        IAI_MEDICAL_REGISTRATION
";

            var result = DBaser.Query<IAI_MEDICAL_REGISTRATION>(sql, wb).First();
            if (result == null)
            {
                throw new Exception("无记录");
            }
            return result;
        }

        public override IAI_MEDICAL_REGISTRATION Update(dynamic item)
        {
            return null;
        }
    }
}
