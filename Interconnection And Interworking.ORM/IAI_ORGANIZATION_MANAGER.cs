using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using System;


namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 医疗结构rom
    /// </summary>
    public class IAI_ORGANIZATION_MANAGER :
        BaseManager<IAI_ORGANIZATION,
            PRPM_IN401030UV01,
            PRPM_IN403010UV01,
            PRPM_IN406010UV01>

    {
        public override IAI_ORGANIZATION Insert(PRPM_IN401030UV01 addEntity)
        {

            var data = new IAI_ORGANIZATION
            {
                organization_id = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.id?.extension,
                organization_code = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.code?.code,
                role_name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.name,
                addr = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.addr,
                telecom = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.telecom?.value,
                effectivetime_high = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.effectiveTime?.high?.value,
                effectivetime_low = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.effectiveTime?.low?.value,
                name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.assignedPrincipalOrganization?.name,
                scoper2_id = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.assignedPrincipalOrganization?.asAffiliate?.scoper2?.id?.extension,
                scoper2_name = addEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.assignedPrincipalOrganization?.asAffiliate?.scoper2?.name,
            };


            var wb = new WhereBuilder();
            wb.And("organization_id", data.organization_id, true);

            if (DBaser.QueryValue<int>("select count(*) from IAI_ORGANIZATION", wb)>0)
                throw new Exception($@"主键冲突{data.organization_id}已存在。");
            DBaser.Insert("IAI_ORGANIZATION");
            DBaser["organization_id"] = data.organization_id;
            DBaser["organization_code"] = data.organization_code;
            DBaser["role_name"] = data.role_name;
            DBaser["addr"] = data.addr;
            DBaser["telecom"] = data.telecom;
            DBaser["effectivetime_high"] = data.effectivetime_high;
            DBaser["effectivetime_low"] = data.effectivetime_low;
            DBaser["name"] = data.name;
            DBaser["scoper2_id"] = data.scoper2_id;
            DBaser["scoper2_name"] = data.scoper2_name;
            DBaser.AcceptChanges();
            return data;

        }



        public override IAI_ORGANIZATION Select(PRPM_IN406010UV01 queryEntity)
        {
            var result = DBaser.Query<IAI_ORGANIZATION>(
              "Select * From IAI_ORGANIZATION",
              new WhereBuilder("organization_id",
                  queryEntity
                ?.controlActProcess
                ?.queryByParameterPayload
                ?.organizationID
                ?.value
                ?.extension)).First();
            if (result==null)
            {
                throw new Exception("无记录");
            }
            return result;

        }



        public override IAI_ORGANIZATION Update(PRPM_IN403010UV01 updateEntity)
        {

            var data = new IAI_ORGANIZATION
            {
                organization_id = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.id?.extension,
                organization_code = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.code?.code,
                role_name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.name,
                addr = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.addr,
                telecom = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.telecom?.value,
                effectivetime_high = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.effectiveTime?.high?.value,
                effectivetime_low = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.effectiveTime?.low?.value,
                name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.assignedPrincipalOrganization?.name,
                scoper2_id = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.assignedPrincipalOrganization?.asAffiliate?.scoper2?.id?.extension,
                scoper2_name = updateEntity?.controlActProcess?.subject?.registrationRequest?.subject1?.assignedEntity?.assignedPrincipalOrganization?.asAffiliate?.scoper2?.name,

            };

            var wb = new WhereBuilder();
            wb.And("organization_id", data.organization_id, true);

            if (DBaser.QueryValue<int>("select count(*) from IAI_ORGANIZATION", wb)<0)
                throw new Exception($@"未查找到结果");
            DBaser.Update("IAI_ORGANIZATION");
            DBaser["organization_id"] = data.organization_id;
            DBaser["organization_code"] = data.organization_code;
            DBaser["role_name"] = data.role_name;
            DBaser["addr"] = data.addr;
            DBaser["telecom"] = data.telecom;
            DBaser["effectivetime_high"] = data.effectivetime_high;
            DBaser["effectivetime_low"] = data.effectivetime_low;
            DBaser["name"] = data.name;
            DBaser["scoper2_id"] = data.scoper2_id;
            DBaser["scoper2_name"] = data.scoper2_name;
            var ok=DBaser.AcceptChanges(wb);
            if (ok < 1)
            {
                throw new Exception("不存在更改信息");
            }
            return data;

        }
    }
}
