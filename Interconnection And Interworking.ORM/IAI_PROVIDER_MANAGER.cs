using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using System;

namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 医护人员orm
    /// </summary>
    public class IAI_PROVIDER_MANAGER : BaseManager<IAI_PROVIDER, PRPM_IN301010UV01, PRPM_IN303010UV01, PRPM_IN306010UV01>
    {
        public override IAI_PROVIDER Insert(PRPM_IN301010UV01 addEntity)
        {
            var data = new IAI_PROVIDER
            {
                healthcareprovider_id = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.id?.extension,
                healthcareprovider_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.code?.code,
                effectivetime_high = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.effectiveTime?.high?.value,
                effectivetime_low = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.effectiveTime?.low?.value,
                id_number = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.id?.extension,
                name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.name?.Value,
                gender_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.administrativeGenderCode?.code,
                birth_time = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.birthTime?.value,
                birth_place = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.birthplace?.addr,
                organization_id = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.asAffiliate?.affiliatedPrincipalOrganization?.id?.extension,
                organization_name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.asAffiliate?.affiliatedPrincipalOrganization?.name,
            };

            var wb = new WhereBuilder();
            wb.And("healthcareprovider_id", data?.healthcareprovider_id, true);

            if (DBaser.QueryValue<int>("select count(*) from IAI_PROVIDER", wb)>0)
                throw new Exception($@"主键冲突{data.healthcareprovider_id}已存在。");

            DBaser.Insert("IAI_PROVIDER");
            DBaser["healthcareprovider_id"] = data.healthcareprovider_id;
            DBaser["healthcareprovider_code"] = data.healthcareprovider_code;
            DBaser["effectivetime_high"] = data.effectivetime_high;
            DBaser["effectivetime_low"] = data.effectivetime_low;
            DBaser["id_number"] = data.id_number;
            DBaser["name"] = data.name;
            DBaser["gender_code"] = data.gender_code;
            DBaser["birth_time"] = data.birth_time;
            DBaser["birth_place"] = data.birth_place;
            DBaser["organization_id"] = data.organization_id;
            DBaser["organization_name"] = data.organization_name;
            DBaser.AcceptChanges();

            return data;
        }

        public override IAI_PROVIDER Select(PRPM_IN306010UV01 queryEntity)
        {
            var wb = new WhereBuilder();
            wb.And("healthcareprovider_id", queryEntity?.controlActProcess?.queryByParameterPayload?.providerID?.value?.extension, true);
            var result= DBaser.Query<IAI_PROVIDER>("Select * From IAI_PROVIDER", wb).First();
            if (result==null)
            {
                throw new Exception("未查找到结果");
            }
            return result;
        }

        public override IAI_PROVIDER Update(PRPM_IN303010UV01 updateEntity)
        {
            var data = new IAI_PROVIDER
            {
                healthcareprovider_id = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.id?.extension,
                healthcareprovider_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.code?.code,
                effectivetime_high = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.effectiveTime?.high?.value,
                effectivetime_low = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.effectiveTime?.low?.value,
                id_number = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.id?.extension,
                name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.name?.Value,
                gender_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.administrativeGenderCode?.code,
                birth_time = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.birthTime?.value,
                birth_place = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.birthplace?.addr,
                organization_id = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.asAffiliate?.affiliatedPrincipalOrganization?.id?.extension,
                organization_name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.healthCareProvider?.healthCarePrincipalPerson?.asAffiliate?.affiliatedPrincipalOrganization?.name,

            };

            var wb = new WhereBuilder();
            wb.And("healthcareprovider_id", data?.healthcareprovider_id, true);

            DBaser.Update("IAI_PROVIDER");
            DBaser["healthcareprovider_id"] = data.healthcareprovider_id;
            DBaser["healthcareprovider_code"] = data.healthcareprovider_code;
            DBaser["effectivetime_high"] = data.effectivetime_high;
            DBaser["effectivetime_low"] = data.effectivetime_low;
            DBaser["id_number"] = data.id_number;
            DBaser["name"] = data.name;
            DBaser["gender_code"] = data.gender_code;
            DBaser["birth_time"] = data.birth_time;
            DBaser["birth_place"] = data.birth_place;
            DBaser["organization_id"] = data.organization_id;
            DBaser["organization_name"] = data.organization_name;
            var ok= DBaser.AcceptChanges(wb);
            if (ok<1)
            {
                throw new Exception("不存在更改信息");
            }
            return data;
        }
    }
}
