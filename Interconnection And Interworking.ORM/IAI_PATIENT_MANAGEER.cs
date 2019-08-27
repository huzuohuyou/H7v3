using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using System;

namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 患者操作orm
    /// </summary>
    public class IAI_PATIENT_MANAGEER : BaseManager<IAI_PATIENT, PRPA_IN201311UV02, IAI_PATIENT, PRPA_IN201305UV02>
    {
        public override IAI_PATIENT Insert(PRPA_IN201311UV02 addEntity)
        {
            var asOtherIDs = addEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asOtherIDs;
            var data = new IAI_PATIENT()
            {
                patient_id = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.id?.extension,
                id_number = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.id?.extension,
                name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.name?.Value,
                telecom = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.telecom?.value,
                gender_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.administrativeGenderCode?.code,
                birth_time = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.birthTime?.value,
                street_address_line = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.streetAddressLine?.Value,
                state = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.state?.Value,
                city = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.city,
                county = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.county,
                street_name_base = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.streetNameBase,
                street_name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.streetName,
                house_number = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.houseNumber,
                postal_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.postalCode,
                marital_status_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.maritalStatusCode?.code,
                ethnic_group_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.ethnicGroupCode?.code,
                occupation_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.asEmployee?.occupationCode?.code,
                employerorganization_name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.asEmployee?.employerOrganization?.name,
                employerorganization_telecom = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.asEmployee?.employerOrganization?.contactParty?.telecom?.value,
                asotherids_id1 = asOtherIDs?.Length >= 1 ? asOtherIDs[0]?.id?.extension : "",
                scopingorganization_id1 = asOtherIDs?.Length >= 1 ? asOtherIDs[0]?.scopingOrganization?.id?.extension : "",
                asotherids_id2 = asOtherIDs?.Length >= 2 ? asOtherIDs[1]?.id?.extension : "",
                scopingorganization_id2 = asOtherIDs?.Length >= 2 ? asOtherIDs[1]?.scopingOrganization?.id?.extension : "",
                personalrelationship_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.personalRelationship?.code,
                personalrelationship_telecom = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.personalRelationship?.telecom?.value,
                relationshipholder1_name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.personalRelationship?.relationshipHolder1?.name,
                providerorganization_id = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.providerOrganization?.id?.extension,
                providerorganization_name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.providerOrganization?.name?.Value,
                beneficiary_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.coveredPartyOf?.coverageRecord?.beneficiary?.beneficiary?.code?.code,
            };

            var wb = new WhereBuilder();
            wb.And("patient_id", data?.patient_id, true);

            if (DBaser.QueryValue<int>("select count(*) from IAI_PATIENT", wb)>0)
                throw new Exception($@"主键冲突{data.patient_id}已存在。");

            DBaser.Insert("IAI_PATIENT");
            DBaser["patient_id"] = data.patient_id;
            DBaser["id_number"] = data.id_number;
            DBaser["name"] = data.name;
            DBaser["telecom"] = data.telecom;
            DBaser["gender_code"] = data.gender_code;
            DBaser["birth_time"] = data.birth_time;
            DBaser["street_address_line"] = data.street_address_line;
            DBaser["state"] = data.state;
            DBaser["city"] = data.city;
            DBaser["county"] = data.county;
            DBaser["street_name_base"] = data.street_name_base;
            DBaser["street_name"] = data.street_name;
            DBaser["house_number"] = data.house_number;
            DBaser["postal_code"] = data.postal_code;
            DBaser["marital_status_code"] = data.marital_status_code;
            DBaser["ethnic_group_code"] = data.ethnic_group_code;
            DBaser["occupation_code"] = data.occupation_code;
            DBaser["employerorganization_name"] = data.employerorganization_name;
            DBaser["employerorganization_telecom"] = data.employerorganization_telecom;
            DBaser["asotherids_id1"] = data.asotherids_id1;
            DBaser["scopingorganization_id1"] = data.scopingorganization_id1;
            DBaser["asotherids_id2"] = data.asotherids_id2;
            DBaser["scopingorganization_id2"] = data.scopingorganization_id2;
            DBaser["personalrelationship_code"] = data.personalrelationship_code;
            DBaser["personalrelationship_telecom"] = data.personalrelationship_telecom;
            DBaser["relationshipholder1_name"] = data.relationshipholder1_name;
            DBaser["providerorganization_id"] = data.providerorganization_id;
            DBaser["providerorganization_name"] = data.providerorganization_name;
            DBaser["beneficiary_code"] = data.beneficiary_code;
            DBaser.AcceptChanges();

            return data;
        }

        public override IAI_PATIENT Select(PRPA_IN201305UV02 queryEntity)
        {
            var result = this.Select(queryEntity
                    ?.controlActProcess
                    ?.queryByParameter
                    ?.parameterList
                    ?.livingSubjectId
                    ?.value
                    ?.extension);

            if (result == null)
            {
                throw new Exception("无记录");
            }
            return result;
        }

        public override IAI_PATIENT Update(IAI_PATIENT data)
        {
            var wb = new WhereBuilder();
            wb.And("patient_id", data?.patient_id, true);

            DBaser.Update("IAI_PATIENT");
            DBaser["patient_id"] = data.patient_id;
            DBaser["id_number"] = data.id_number;
            DBaser["name"] = data.name;
            DBaser["telecom"] = data.telecom;
            DBaser["gender_code"] = data.gender_code;
            DBaser["birth_time"] = data.birth_time;
            DBaser["street_address_line"] = data.street_address_line;
            DBaser["state"] = data.state;
            DBaser["city"] = data.city;
            DBaser["county"] = data.county;
            DBaser["street_name_base"] = data.street_name_base;
            DBaser["street_name"] = data.street_name;
            DBaser["house_number"] = data.house_number;
            DBaser["postal_code"] = data.postal_code;
            DBaser["marital_status_code"] = data.marital_status_code;
            DBaser["ethnic_group_code"] = data.ethnic_group_code;
            DBaser["occupation_code"] = data.occupation_code;
            DBaser["employerorganization_name"] = data.employerorganization_name;
            DBaser["employerorganization_telecom"] = data.employerorganization_telecom;
            DBaser["asotherids_id1"] = data.asotherids_id1;
            DBaser["scopingorganization_id1"] = data.scopingorganization_id1;
            DBaser["asotherids_id2"] = data.asotherids_id2;
            DBaser["scopingorganization_id2"] = data.scopingorganization_id2;
            DBaser["personalrelationship_code"] = data.personalrelationship_code;
            DBaser["personalrelationship_telecom"] = data.personalrelationship_telecom;
            DBaser["relationshipholder1_name"] = data.relationshipholder1_name;
            DBaser["providerorganization_id"] = data.providerorganization_id;
            DBaser["providerorganization_name"] = data.providerorganization_name;
            DBaser["beneficiary_code"] = data.beneficiary_code;
            if (DBaser.AcceptChanges(wb) <= 0)
                throw new Exception("修改失敗！");

            return data.Copy();
        }

        public void Merge(PRPA_IN201304UV02 mergeEntity)
        {
            var olds = this.Select(mergeEntity?.controlActProcess?.subject?.registrationEvent?.replacementOf?.priorRegistration?.subject1?.priorRegisteredRole?.id?.extension);
            if (olds is null)
                throw new Exception("不存在 先前的注册角色");

            var news = this.Select(mergeEntity?.controlActProcess?.subject?.registrationEvent?.subject1?.patient?.id.extension);
            if (news is null || news.patient_id.IsEmpty(true))
                throw new Exception("不存在 病人");

            var wb = new WhereBuilder();
            wb["patient_id", true] = news.patient_id;
            DBaser.Delete("IAI_PATIENT", wb);

            DBaser.Update("IAI_PATIENT");
            DBaser["patient_id"] = news.patient_id;

            wb["patient_id", true] = olds.patient_id;
            DBaser.AcceptChanges(wb);
        }

        public bool DeleteById(string id)
        {
            var wb = new WhereBuilder();
            wb.And("patient_id", id, true);

            return DBaser.Delete("IAI_PATIENT", wb) > 0;
        }

        public IAI_PATIENT Select(string id)
        {
            var wb = new WhereBuilder();
            wb.And("patient_id", id, true);

            return DBaser.Query<IAI_PATIENT>("Select * From IAI_PATIENT", wb).First();
        }

        public IAI_PATIENT Update(PRPA_IN201314UV02 updateEntity)
        {
            var asOtherIDs = updateEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asOtherIDs;
            var data = new IAI_PATIENT()
            {
                patient_id = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.id?.extension,
                id_number = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.id?.extension,
                name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.name?.Value,
                telecom = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.telecom?.value,
                gender_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.administrativeGenderCode?.code,
                birth_time = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.birthTime?.value,
                street_address_line = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.streetAddressLine?.Value,
                state = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.state?.Value,
                city = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.city,
                county = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.county,
                street_name_base = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.streetNameBase,
                street_name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.streetName,
                house_number = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.houseNumber,
                postal_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.addr?.postalCode,
                marital_status_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.maritalStatusCode?.code,
                ethnic_group_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.ethnicGroupCode?.code,
                occupation_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.asEmployee?.occupationCode?.code,
                employerorganization_name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.asEmployee?.employerOrganization?.name,
                employerorganization_telecom = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.asEmployee?.employerOrganization?.contactParty?.telecom?.value,
                asotherids_id1 = asOtherIDs?.Count() >= 1 ? asOtherIDs[0]?.id?.extension : "",
                scopingorganization_id1 = asOtherIDs?.Count() >= 1 ? asOtherIDs[0]?.scopingOrganization?.id?.extension : "",
                asotherids_id2 = asOtherIDs?.Count() >= 2 ? asOtherIDs[1]?.id?.extension : "",
                scopingorganization_id2 = asOtherIDs?.Count() >= 2 ? asOtherIDs[1]?.scopingOrganization?.id?.extension : "",
                personalrelationship_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.personalRelationship?.code,
                personalrelationship_telecom = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.personalRelationship?.telecom?.value,
                relationshipholder1_name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.patientPerson?.personalRelationship?.relationshipHolder1?.name,
                providerorganization_id = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.providerOrganization?.id?.extension,
                providerorganization_name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.providerOrganization?.name?.Value,
                beneficiary_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.patient?.coveredPartyOf?.coverageRecord?.beneficiary?.beneficiary?.code?.code,
            };

            return Update(data);
        }
    }
}
