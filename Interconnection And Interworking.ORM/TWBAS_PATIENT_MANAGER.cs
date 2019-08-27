using System;
using System.Collections.Generic;
using System.Linq;
using App.FunctionLibrary;
using Framework.ORM;
using InterconnectionAndInterworking.Entity;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;

namespace InterconnectionAndInterworking.ORM
{

    //public delegate  void DoWork(PRPA_IN201311UV02 x);
    public class TWBAS_PATIENT_MANAGER : 
        BaseManager, 
        IDB_MANAGER<
            TWBAS_PATIENT, 
            PRPA_IN201311UV02, 
            PRPA_IN201314UV02, 
            PRPA_IN201305UV02, 
            PRPA_IN201311UV02>
    {


        public bool Delete(PRPA_IN201311UV02 t)
        {
            throw new NotImplementedException();
        }

        //public void Do(Action<RequestEntity> action, RequestEntity p)
        //{
        //    action(p);
        //}

        public List<TWBAS_PATIENT> FindList(PRPA_IN201305UV02 t ,WhereBuilder wb)
        {
            //var sql = "select * from TWBAS_PATIENT";
            //return DBaser.Query<TWBAS_PATIENT>(sql, wb).ToList();
            return null;
        }

        public TWBAS_PATIENT FindOne(PRPA_IN201305UV02 t)
        {
            try
            {
                var result = Instance.db.Queryable<TWBAS_PATIENT>().Where(r => r.PTNO == t.controlActProcess.queryByParameter.parameterList.livingSubjectId.value.extension).ToList().FirstOrDefault();//.InSingle(t.controlActProcess.queryByParameter.parameterList.livingSubjectId.value.extension);
                if (result==null)
                {
                    throw new Exception("未查找到结果");
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Add(PRPA_IN201311UV02 requestEntity)
        {

            #region 临时方案
            //try
            //{
            //    var data = new TWBAS_PATIENT()
            //    {
            //        PTNO = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.id.extension,
            //        SNAME = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.name.Value,
            //        SEX = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.administrativeGenderCode.code,
            //        BIRTHDATE = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.birthTime.DateTime.Value,
            //        JUMIN = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.id.extension,
            //        //DBaser["STARTDATE"] = "";
            //        //DBaser["LASTDATE"] = "";
            //        POSTCODE = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.addr.postalCode,
            //        JUSO = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.addr.streetAddressLine.Value,
            //        //DBaser["JIYUKCODE"] = "";
            //        TEL = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.telecom.value,
            //        //DBaser["TEL1"] = "";
            //        CPNO = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asOtherIDs.ToList().FirstOrDefault()?.id?.extension.SubString(14),
            //        //DBaser["SABUN"] = "";
            //        //DBaser["EMBPRT"] = "";
            //        //DBaser["BI"] = "";
            //        //DBaser["PNAME"] = "";
            //        //DBaser["GBGWANGE"] = "";
            //        //DBaser["KIHO"] = "";
            //        //DBaser["GKIHO"] = "";
            //        //DBaser["GBAREA"] = "";
            //        //DBaser["AREADATE"] = "";
            //        //DBaser["KIDNEYOPDATE"] = "";
            //        //DBaser["CHECKFLAG"] = "";
            //        //DBaser["CHECKREMARK"] = "";
            //        //DBaser["GBBOHUN"] = "";
            //        DEPTCODE = "",
            //        //DBaser["DRCODE"] = "";
            //        //DBaser["GBSPC"] = "";
            //        //DBaser["GBGAMEK"] = "";
            //        //DBaser["GBBUNUP"] = "";
            //        //DBaser["REMARK"] = "";
            //        //DBaser["JINILSU"] = "";
            //        //DBaser["JINAMT"] = "";
            //        //DBaser["TUYAKGWA"] = "";
            //        //DBaser["TUYAKMONTH"] = "";
            //        //DBaser["TUYAKJULDATE"] = "";
            //        //DBaser["TUYAKILSU"] = "";
            //        //DBaser["CONSULT"] = "";
            //        //DBaser["RELIGION"] = "";
            //        //DBaser["GYOGUCODE"] = "";
            //        MARRIAGE = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.maritalStatusCode.code.SubString(1),
            //        PEOPLE = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.ethnicGroupCode.code,
            //        //DBaser["NATIONAL"] = "";
            //        JOB = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.occupationCode.code,
            //        //DBaser["JOBPOST"] = "";
            //        //DBaser["JOBADDRESS"] = t.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.name;
            //        JOBTEL = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.contactParty.telecom.value,
            //        JOBNAME = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.name,
            //        //DBaser["BIRTHPLACE"] = ""requestEntity.;
            //        GKIHO2 = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asOtherIDs.ToList().FirstOrDefault()?.id?.extension,
            //        //DBaser["BANNO"] = "";
            //        //DBaser["CARDID"] = "";
            //        IDNUMBER = "",// t.controlActProcess.subject.registrationRequest.author.assignedEntity.id.extension.SubString(6),
            //        INSERTID = "",
            //        INSERTDATE = DateTime.Now,
            //    };
            //    Instance.db.Insertable(data).ExecuteCommand();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion

            #region 新框架 DBaser 为null  待解决
            try
            {
                DBaser.Insert("TWBAS_PATIENT");
                DBaser["PTNO"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.id.extension;
                DBaser["SNAME"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.name.Value;
                DBaser["SEX"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.administrativeGenderCode.code;
                DBaser["BIRTHDATE"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.birthTime.value;
                DBaser["JUMIN"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.id.extension;
                //DBaser["STARTDATE"] = "";
                //DBaser["LASTDATE"] = "";
                DBaser["POSTCODE"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.addr.postalCode;
                DBaser["JUSO"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.addr.streetAddressLine.Value.PadRight(60, ' ').Substring(0, 60);
                //DBaser["JIYUKCODE"] = "";
                DBaser["TEL"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.telecom.value;
                //DBaser["TEL1"] = "";
                DBaser["CPNO"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asOtherIDs.ToList().FirstOrDefault()?.id?.extension;
                //DBaser["SABUN"] = "";
                //DBaser["EMBPRT"] = "";
                //DBaser["BI"] = "";
                //DBaser["PNAME"] = "";
                //DBaser["GBGWANGE"] = "";
                //DBaser["KIHO"] = "";
                //DBaser["GKIHO"] = "";
                //DBaser["GBAREA"] = "";
                //DBaser["AREADATE"] = "";
                //DBaser["KIDNEYOPDATE"] = "";
                //DBaser["CHECKFLAG"] = "";
                //DBaser["CHECKREMARK"] = "";
                //DBaser["GBBOHUN"] = "";
                DBaser["DEPTCODE"] = "";
                //DBaser["DRCODE"] = "";
                //DBaser["GBSPC"] = "";
                //DBaser["GBGAMEK"] = "";
                //DBaser["GBBUNUP"] = "";
                //DBaser["REMARK"] = "";
                //DBaser["JINILSU"] = "";
                //DBaser["JINAMT"] = "";
                //DBaser["TUYAKGWA"] = "";
                //DBaser["TUYAKMONTH"] = "";
                //DBaser["TUYAKJULDATE"] = "";
                //DBaser["TUYAKILSU"] = "";
                //DBaser["CONSULT"] = "";
                //DBaser["RELIGION"] = "";
                //DBaser["GYOGUCODE"] = "";
                DBaser["MARRIAGE"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.maritalStatusCode.code;
                DBaser["PEOPLE"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.ethnicGroupCode.code;
                //DBaser["NATIONAL"] = "";
                DBaser["JOB"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.occupationCode.code;
                //DBaser["JOBPOST"] = "";
                //DBaser["JOBADDRESS"] = t.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.name;
                DBaser["JOBTEL"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.contactParty.telecom.value;
                DBaser["JOBNAME"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.name;
                //DBaser["BIRTHPLACE"] = "";
                DBaser["GKIHO2"] = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asOtherIDs.ToList().FirstOrDefault()?.id?.extension;
                //DBaser["BANNO"] = "";
                //DBaser["CARDID"] = "";
                DBaser["IDNUMBER"] = requestEntity.controlActProcess.subject.registrationRequest.author.assignedEntity.id.extension;
                DBaser["INSERTID"] = "";
                DBaser["INSERTDATE"] = DateTime.Now;
                DBaser.AcceptChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            #endregion

        }

        public int Update(PRPA_IN201314UV02 requestEntity)
        {
            try
            {

                var data = new TWBAS_PATIENT()
                {
                    PTNO = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.id.extension,
                    SNAME = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.name.Value,
                    SEX = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.administrativeGenderCode.code,
                    BIRTHDATE = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.birthTime.DateTime.Value,
                    JUMIN = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.id.extension,
                    //DBaser["STARTDATE"] = "";
                    //DBaser["LASTDATE"] = "";
                    POSTCODE = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.addr.postalCode,
                    JUSO = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.addr.streetAddressLine.Value,
                    //DBaser["JIYUKCODE"] = "";
                    TEL = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.telecom.value,
                    //DBaser["TEL1"] = "";
                    CPNO = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asOtherIDs.ToList().FirstOrDefault()?.id?.extension.SubString(14),
                    //DBaser["SABUN"] = "";
                    //DBaser["EMBPRT"] = "";
                    //DBaser["BI"] = "";
                    //DBaser["PNAME"] = "";
                    //DBaser["GBGWANGE"] = "";
                    //DBaser["KIHO"] = "";
                    //DBaser["GKIHO"] = "";
                    //DBaser["GBAREA"] = "";
                    //DBaser["AREADATE"] = "";
                    //DBaser["KIDNEYOPDATE"] = "";
                    //DBaser["CHECKFLAG"] = "";
                    //DBaser["CHECKREMARK"] = "";
                    //DBaser["GBBOHUN"] = "";
                    DEPTCODE = "",
                    //DBaser["DRCODE"] = "";
                    //DBaser["GBSPC"] = "";
                    //DBaser["GBGAMEK"] = "";
                    //DBaser["GBBUNUP"] = "";
                    //DBaser["REMARK"] = "";
                    //DBaser["JINILSU"] = "";
                    //DBaser["JINAMT"] = "";
                    //DBaser["TUYAKGWA"] = "";
                    //DBaser["TUYAKMONTH"] = "";
                    //DBaser["TUYAKJULDATE"] = "";
                    //DBaser["TUYAKILSU"] = "";
                    //DBaser["CONSULT"] = "";
                    //DBaser["RELIGION"] = "";
                    //DBaser["GYOGUCODE"] = "";
                    MARRIAGE = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.maritalStatusCode.code.SubString(1),
                    PEOPLE = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.ethnicGroupCode.code,
                    //DBaser["NATIONAL"] = "";
                    JOB = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.occupationCode.code,
                    //DBaser["JOBPOST"] = "";
                    //DBaser["JOBADDRESS"] = t.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.name;
                    JOBTEL = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.contactParty.telecom.value,
                    JOBNAME = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asEmployee.employerOrganization.name,
                    //DBaser["BIRTHPLACE"] = ""requestEntity.;
                    GKIHO2 = requestEntity.controlActProcess.subject.registrationRequest.subject1.patient.patientPerson.asOtherIDs.ToList().FirstOrDefault()?.id?.extension,
                    //DBaser["BANNO"] = "";
                    //DBaser["CARDID"] = "";
                    IDNUMBER = "",// t.controlActProcess.subject.registrationRequest.author.assignedEntity.id.extension.SubString(6),
                    INSERTID = "",
                    INSERTDATE = DateTime.Now,
                };
                return Instance.db.Updateable(data).ExecuteCommand();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
