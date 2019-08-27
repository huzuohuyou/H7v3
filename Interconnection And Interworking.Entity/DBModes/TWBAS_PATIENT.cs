using System;
using App.FunctionLibrary;
using SqlSugar;

namespace InterconnectionAndInterworking.Entity.DBModes
{
    [SugarTable("TWBAS_PATIENT")]
    public class TWBAS_PATIENT
    {
        public string PTNO { get; set; }

        public string SNAME { get; set; }

        public string SEX { get; set; }

        public DateTime? BIRTHDATE { get; set; }

        public string JUMIN { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? LASTDATE { get; set; }

        public string POSTCODE { get; set; }

        public string JUSO { get; set; }

        public string JIYUKCODE { get; set; }

        public string TEL { get; set; }

        public string TEL1 { get; set; }

        public string CPNO { get; set; }

        public string SABUN { get; set; }

        public string EMBPRT { get; set; }

        public string BI { get; set; }

        public string PNAME { get; set; }

        public string GBGWANGE { get; set; }

        public string KIHO { get; set; }

        public string GKIHO { get; set; }

        public string GBAREA { get; set; }

        public string AREADATE { get; set; }

        public DateTime? KIDNEYOPDATE { get; set; }

        public string CHECKFLAG { get; set; }

        public string CHECKREMARK { get; set; }

        public string GBBOHUN { get; set; }

        public string DEPTCODE { get; set; }

        public string DRCODE { get; set; }

        public string GBSPC { get; set; }

        public string GBGAMEK { get; set; }

        public string GBBUNUP { get; set; }

        public string REMARK { get; set; }

        public string JINILSU { get; set; }

        public string JINAMT { get; set; }

        public string TUYAKGWA { get; set; }

        public string TUYAKMONTH { get; set; }

        public double TUYAKJULDATE { get; set; }

        public double TUYAKILSU { get; set; }

        public string CONSULT { get; set; }

        public string RELIGION { get; set; }

        public string GYOGUCODE { get; set; }

        public string MARRIAGE { get; set; }

        public string PEOPLE { get; set; }

        public string NATIONAL { get; set; }

        public string JOB { get; set; }

        public string JOBPOST { get; set; }

        public string JOBADDRESS { get; set; }

        public string JOBTEL { get; set; }

        public string JOBNAME { get; set; }

        public string BIRTHPLACE { get; set; }

        public string GKIHO2 { get; set; }

        public string BANNO { get; set; }

        public string CARDID { get; set; }

        public string IDNUMBER { get; set; }

        public string INSERTID { get; set; }

        public DateTime INSERTDATE { get; set; }
    }
}
