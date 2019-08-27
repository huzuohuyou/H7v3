using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;
using System;
using System.Collections.Generic;


namespace InterconnectionAndInterworking.ORM
{
    /// <summary>
    /// 申请单orm
    /// </summary>
    public class IAI_OBSERVATION_MANAGER : 
        BaseManager<
            IAI_OBSERVATION,
            POOR_IN200901UV,
            DBNull,
            QUMT_IN020030PL
            >
    {
        public override IAI_OBSERVATION Insert(POOR_IN200901UV addEntity)
        {

            var data = new IAI_OBSERVATION
            {
                observation_id = addEntity?.controlActProcess?.subject?.observationRequest?.id?.extension,
                observation_type = addEntity?.controlActProcess?.subject?.observationRequest?.code,
                observation_text = addEntity?.controlActProcess?.subject?.observationRequest?.text,
                effectivetime_high = addEntity.controlActProcess?.subject?.observationRequest?.effectiveTime?.high?.value,
                effectivetime_low = addEntity.controlActProcess?.subject?.observationRequest?.effectiveTime?.low?.value,
                prioritycode = addEntity?.controlActProcess?.subject?.observationRequest?.priorityCode?.code,
                specimen_id = addEntity?.controlActProcess?.subject?.observationRequest?.specimen?.specimen?.id.extension,
                specimen_code = addEntity?.controlActProcess?.subject?.observationRequest?.specimen?.specimen?.code,
                specimen_desc = addEntity?.controlActProcess?.subject?.observationRequest?.specimen?.specimen?.specimenNatural.desc,
                additive3 = addEntity?.controlActProcess?.subject?.observationRequest?.specimen?.specimen?.specimenNatural?.additive?.additive3?.desc?.Value,
                productOf_time = addEntity?.controlActProcess?.subject?.observationRequest?.specimen?.specimen?.productOf.time.value,
                specimenProcessStep_time = addEntity?.controlActProcess?.subject?.observationRequest?.specimen?.specimen?.productOf?.specimenProcessStep?.effectiveTime?.value,


                recordtarget = addEntity?.controlActProcess?.subject?.observationRequest?.recordTarget?.patient?.id[0].extension,
                author_time = addEntity?.controlActProcess?.subject?.observationRequest?.author?.time.value,
                signaturetext = addEntity?.controlActProcess?.subject?.observationRequest?.author?.signatureText,
                author_assignedentity_id = addEntity?.controlActProcess?.subject?.observationRequest?.author?.assignedEntity?.id.extension,
                assignedperson_name = addEntity?.controlActProcess?.subject?.observationRequest?.author?.assignedEntity?.assignedPerson?.name.Value,
                representedorganization_id = addEntity?.controlActProcess?.subject?.observationRequest?.author?.assignedEntity?.representedOrganization?.id.extension,
                representedorganization_name = addEntity?.controlActProcess?.subject?.observationRequest?.author?.assignedEntity?.representedOrganization?.name,
                verifier_time = addEntity?.controlActProcess?.subject?.observationRequest?.verifier?.time.value,
                verifier_signaturetext = addEntity?.controlActProcess?.subject?.observationRequest?.verifier?.signatureText,
                verifier_assignedentity_id = addEntity?.controlActProcess?.subject?.observationRequest?.verifier?.assignedEntity?.id.extension,
                verifier_assignedperson_name = addEntity?.controlActProcess?.subject?.observationRequest?.verifier?.assignedEntity?.assignedPerson?.name.Value,
                goal_text = addEntity?.controlActProcess?.subject?.observationRequest?.goal?.observationEventCriterion?.text,
                goal_reason = addEntity?.controlActProcess?.subject?.observationRequest?.reason[0].observation.value.Value,
                annotation_text = addEntity?.controlActProcess?.subject?.observationRequest?.subjectOf6?.annotation?.text,
                annotation_author_id = addEntity?.controlActProcess?.subject?.observationRequest?.subjectOf6?.annotation?.author?.assignedEntity?.id.extension,
                annotation_author_name = addEntity?.controlActProcess?.subject?.observationRequest?.subjectOf6?.annotation?.author?.assignedEntity?.assignedPerson?.name.Value,
                represented_organization_id = addEntity?.controlActProcess?.subject?.observationRequest?.subjectOf6?.annotation?.author?.assignedEntity?.representedOrganization?.id.extension,
                represented_organization_name = addEntity?.controlActProcess?.subject?.observationRequest?.subjectOf6?.annotation?.author?.assignedEntity?.representedOrganization?.name,

                encounter_id = addEntity.controlActProcess?.subject?.substanceAdministrationRequest?.componentOf1?.encounter?.id,

            };


            var wb = new WhereBuilder();
            wb.And("observation_id", data.observation_id, true);
            if (DBaser.QueryValue<int>("select count(*) from IAI_OBSERVATION", wb)>0)
                throw new Exception($@"主键冲突{data.observation_id}已存在。");
            DBaser.Insert("IAI_OBSERVATION");
            DBaser["observation_id"] = data.observation_id;
            DBaser["observation_type"] = data.observation_type;
            DBaser["observation_text"] = data.observation_text;
            DBaser["effectivetime_high"] = data.effectivetime_high;
            DBaser["effectivetime_low"] = data.effectivetime_low;
            DBaser["prioritycode"] = data.prioritycode;
            DBaser["specimen_id"] = data.specimen_id;
            DBaser["specimen_code"] = data.specimen_code;
            DBaser["specimen_desc"] = data.specimen_desc;
            DBaser["additive3"] = data.additive3;
            DBaser["productOf_time"] = data.productOf_time;
            DBaser["specimenProcessStep_time"] = data.specimenProcessStep_time;
            DBaser["recordtarget"] = data.recordtarget;
            DBaser["author_time"] = data.author_time;
            DBaser["signaturetext"] = data.signaturetext;
            DBaser["author_assignedentity_id"] = data.author_assignedentity_id;
            DBaser["assignedperson_name"] = data.assignedperson_name;
            DBaser["representedorganization_id"] = data.representedorganization_id;
            DBaser["representedorganization_name"] = data.representedorganization_name;
            DBaser["verifier_time"] = data.verifier_time;
            DBaser["verifier_signaturetext"] = data.verifier_signaturetext;
            DBaser["verifier_assignedentity_id"] = data.verifier_assignedentity_id;
            DBaser["verifier_assignedperson_name"] = data.verifier_assignedperson_name;
            DBaser["goal_text"] = data.goal_text;
            DBaser["goal_reason"] = data.goal_reason;
            DBaser["annotation_text"] = data.annotation_text;
            DBaser["annotation_author_id"] = data.annotation_author_id;
            DBaser["annotation_author_name"] = data.annotation_author_name;
            DBaser["represented_organization_id"] = data.represented_organization_id;
            DBaser["represented_organization_name"] = data.represented_organization_name;
            DBaser.AcceptChanges();
            return data;

        }



        public override IAI_OBSERVATION Select(QUMT_IN020030PL queryEntity)
        {
            var result = DBaser.Query<IAI_OBSERVATION>(
               "Select * From IAI_OBSERVATION",
               new WhereBuilder("observation_id",
                   queryEntity
                ?.controlActProcess
                ?.queryByParameter
                ?.queryByParameterPayload
                ?.actId
                ?.value
                ?.extension)).First();

            if (result == null)
            {
                throw new Exception("无记录");
            }
            return result;

        }



        public override IAI_OBSERVATION Update(DBNull updateEntity)
        {
            throw new NotImplementedException();
        }
    }
}
