using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using System;


namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 医嘱orm
    /// </summary>
    public class IAI_ORDER_MANAGER :
        BaseManager<
            IAI_ORDER,
            POOR_IN200901UV,
            DBNull,
            QUMT_IN020030PL
            >
    {
        public override IAI_ORDER Insert(POOR_IN200901UV addEntity)
        {
            
                string _effectivetime_high ="", _effectivetime_low  ="", _effectivetime_period="", _effectivetime_unit="";
                if (addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime.Count()>=1)
                {
                     _effectivetime_high = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime[0]?.high?.value;
                    _effectivetime_low = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime[0]?.low?.value;
                   
                }
                if (addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime.Count() >= 2)
                {
                       _effectivetime_period = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime[1]?.period?.value;
                    _effectivetime_unit = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime[1]?.period?.unit;
                }
                var data = new IAI_ORDER
                {
                    order_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.id?.extension,
                    order_type_code = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.code?.code,
                    text = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.text,
                    effectivetime_high = _effectivetime_high,// addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime[0]?.high?.value,
                    effectivetime_low = _effectivetime_low,//addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime[0]?.low?.value,
                    effectivetime_period = _effectivetime_period,//addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime[1]?.period?.value,
                    effectivetime_unit = _effectivetime_unit,// addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.effectiveTime[1]?.period?.unit,
                    route_code = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.routeCode?.code,
                    dose_quantity = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.doseQuantity?.value,
                    dose_quantity_unit= addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.doseQuantity?.unit,
                    numertor = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.doseCheckQuantity?.numerator?.value,
                    denominator = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.doseCheckQuantity?.denominator?.value,
                    unit_code = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.administrationUnitCode?.code,
                    medicine_name = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.consumable2?.medication1?.administerableMedicine?.name,
                    capacity_quantity = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.consumable2?.medication1?.administerableMedicine?.asContent?.containerPackagedMedicine?.capacityQuantity?.value,
                    patient_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.componentOf1?.encounter?.subject?.patient?.patientPerson?.id?.extension,
                    author_time = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.author?.time?.value,
                    signature_text = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.author?.signatureText,
                    assignedentity_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.author?.assignedEntity?.id.extension,
                    assignedperson_name = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.author?.assignedEntity?.assignedPerson?.name?.Value,
                    organization_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.author?.assignedEntity?.representedOrganization?.id?.extension,
                    organization_name = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.author?.assignedEntity?.representedOrganization?.name,
                    verifier_time = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.verifier?.time?.value,
                    verifier_assignedentity_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.verifier?.assignedEntity?.id?.extension,
                    verifier_assignedentity_name = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.verifier?.assignedEntity?.assignedPerson?.name?.Value,
                    annotion_text = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.subjectOf6?.annotation?.text,
                    annotion_status_code = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.subjectOf6?.annotation?.statusCode.code,
                    annotion_author_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.subjectOf6?.annotation?.author?.assignedEntity?.id?.extension,
                    annotion_author_name = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.subjectOf6?.annotation?.author?.assignedEntity?.assignedPerson?.name?.Value,
                    annotion_organization_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.subjectOf6?.annotation?.author?.assignedEntity?.representedOrganization?.id?.extension,
                    annotion_organization_name = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.subjectOf6?.annotation?.author?.assignedEntity?.representedOrganization?.name,
                    encounter_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.componentOf1?.encounter?.id,

                };
            

            var wb = new WhereBuilder();
            wb.And("order_id", data.order_id, true);
            if (DBaser.QueryValue<int>("select count(*) from IAI_ORDER", wb)>0)
                throw new Exception($@"主键冲突{data.order_id}已存在。");
            DBaser.Insert("IAI_ORDER");
            DBaser["order_id"] = data.order_id;
            DBaser["order_type_code"] = data.order_type_code;
            DBaser["text"] = data.text;
            DBaser["effectivetime_high"] = data.effectivetime_high;
            DBaser["effectivetime_low"] = data.effectivetime_low;
            DBaser["effectivetime_period"] = data.effectivetime_period;
            DBaser["effectivetime_unit"] = data.effectivetime_unit;
            DBaser["route_code"] = data.route_code;
            DBaser["dose_quantity"] = data.dose_quantity;
            DBaser["dose_quantity_unit"] = data.dose_quantity_unit;
            DBaser["numertor"] = data.numertor;
            DBaser["denominator"] = data.denominator;
            DBaser["unit_code"] = data.unit_code;
            DBaser["medicine_name"] = data.medicine_name;
            DBaser["capacity_quantity"] = data.capacity_quantity;
            DBaser["patient_id"] = data.patient_id;
            DBaser["author_time"] = data.author_time;
            
            
            DBaser["signature_text"] = data.signature_text;

            DBaser["assignedentity_id"] = data.assignedentity_id;
            DBaser["assignedperson_name"] = data.assignedperson_name;
            DBaser["organization_id"] = data.organization_id;

            DBaser["organization_name"] = data.organization_name;
            DBaser["verifier_time"] = data.verifier_time;

            DBaser["verifier_assignedentity_id"] = data.verifier_assignedentity_id;
            DBaser["verifier_assignedentity_name"] = data.verifier_assignedentity_name;
            DBaser["annotion_text"] = data.annotion_text;
            DBaser["annotion_status_code"] = data.annotion_status_code;
            DBaser["annotion_author_id"] = data.annotion_author_id;
            DBaser["annotion_author_name"] = data.annotion_author_name;
            DBaser["annotion_organization_id"] = data.annotion_organization_id;
            DBaser["annotion_organization_name"] = data.annotion_organization_name;
            DBaser["encounter_id"] = data.encounter_id;
            DBaser.AcceptChanges();
            return data;

        }



        public override IAI_ORDER Select(QUMT_IN020030PL queryEntity)
        {
            var result = DBaser.Query<IAI_ORDER>(
               "Select * From IAI_ORDER",
               new WhereBuilder("order_id",
                   queryEntity
                    ?.controlActProcess
                    ?.queryByParameter
                    ?.queryByParameterPayload
                    ?.actId
                    ?.value
                    ?.extension)).First();
            if (result==null)
            {
                throw new Exception("无记录");
            }
            return result;

           
           
        }


        public override IAI_ORDER Update(DBNull updateEntity)
        {
            throw new NotImplementedException();
        }
    }
}
