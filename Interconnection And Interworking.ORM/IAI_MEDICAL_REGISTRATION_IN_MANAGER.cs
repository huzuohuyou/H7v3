using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using System;

namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 住院操作orm
    /// </summary>
    public class IAI_MEDICAL_REGISTRATION_IN_MANAGER : BaseManager<IAI_MEDICAL_REGISTRATION, PRPA_IN402001UV02, dynamic, PRPA_IN900300UV02>
    {
        public override IAI_MEDICAL_REGISTRATION Insert(PRPA_IN402001UV02 addEntity)
        {
            var data = new IAI_MEDICAL_REGISTRATION()
            {
                encounterevent_id = addEntity.controlActProcess?.subject?.encounterEvent?.id?.extension,
                type_code = addEntity.controlActProcess?.subject?.encounterEvent?.code?.code,
                effective_time = addEntity.controlActProcess?.subject?.encounterEvent?.effectiveTime?.value,
                original_text = addEntity.controlActProcess?.subject?.encounterEvent?.reasonCode?.originalText,
                patient_id = addEntity.controlActProcess?.subject?.encounterEvent?.subject?.patient?.id.code,
                patient_name = addEntity.controlActProcess?.subject?.encounterEvent?.subject?.patient?.patientPerson?.name.Value,
                consultant_id = addEntity.controlActProcess?.subject?.encounterEvent?.admitter?.assignedPerson?.id?.extension,
                consultant_name = addEntity.controlActProcess?.subject?.encounterEvent?.admitter?.assignedPerson?.assignedPerson?.name,
                location_id = addEntity.controlActProcess?.subject?.encounterEvent?.location?.serviceDeliveryLocation?.location?.id?.extension,
                location_name = addEntity.controlActProcess?.subject?.encounterEvent?.location?.serviceDeliveryLocation?.location?.name,
                organization_id = addEntity.controlActProcess?.subject?.encounterEvent?.location?.serviceDeliveryLocation?.serviceProviderOrganization?.id?.extension,
                medical_type = EncounterEventTypeCode.ADMITTER.Value(),
            };

            var wb = new WhereBuilder();
            wb.And("encounterevent_id", data.encounterevent_id, true);
            wb.And("medical_type", data.medical_type);

            if (DBaser.QueryValue<int>("select count(*) from IAI_MEDICAL_REGISTRATION", wb)>0)
                throw new Exception($@"主键冲突{data.consultant_id}已存在。");

            DBaser.Insert("IAI_MEDICAL_REGISTRATION");
            DBaser["encounterevent_id"] = data.encounterevent_id;
            DBaser["type_code"] = data.type_code;
            DBaser["effective_time"] = data.effective_time;
            DBaser["original_text"] = data.original_text;
            DBaser["patient_id"] = data.patient_id;
            DBaser["patient_name"] = data.patient_name;
            DBaser["consultant_id"] = data.consultant_id;
            DBaser["consultant_name"] = data.consultant_name;
            DBaser["location_id"] = data.location_id;
            DBaser["location_name"] = data.location_name;
            DBaser["organization_id"] = data.organization_id;
            DBaser["medical_type"] = data.medical_type;



            DBaser.AcceptChanges();
            return data;
        }

        public override IAI_MEDICAL_REGISTRATION Select(PRPA_IN900300UV02 queryEntity)
        {
            var result= DBaser.Query<IAI_MEDICAL_REGISTRATION>(
                "Select * From IAI_MEDICAL_REGISTRATION",
                new WhereBuilder("medical_type", EncounterEventTypeCode.ADMITTER).And("encounterevent_id", queryEntity
                    ?.controlActProcess
                    ?.queryByParameterPayload
                    ?.careEventID
                    ?.value
                    ?.extension)).First();

            if (result == null)
            {
                throw new Exception("无记录");
            }
            return result;
        }

        [Obsolete]
        public override IAI_MEDICAL_REGISTRATION Update(dynamic updateEntity)
        {
            return null;
        }
    }
}
