using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.FunctionLibrary;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.MessageModel;

namespace InterconnectionAndInterworking.ORM
{

    public class TWBAS_PASS_MANAGER :
        BaseManager,
        IDB_MANAGER<
            TWBAS_PASS, 
            PRPM_IN301010UV01, 
            PRPM_IN303010UV01, 
            PRPM_IN306010UV01, 
            PRPA_IN201311UV02>

    {
        public void Add(PRPM_IN301010UV01 addEntity)
        {
            try
            {
                var data = new TWBAS_PASS {
                    name = addEntity.controlActProcess.subject.registrationRequest.subject1.healthCareProvider.healthCarePrincipalPerson.name.Value,
                    buse = addEntity.controlActProcess.subject.registrationRequest.subject1.healthCareProvider.healthCarePrincipalPerson.asAffiliate.affiliatedPrincipalOrganization.id.extension,
                    password="",
                };
                Instance.db.Insertable(data).ExecuteCommand();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(PRPA_IN201311UV02 deleteEntity)
        {
            throw new NotImplementedException();
        }

        public List<TWBAS_PASS> FindList(PRPM_IN306010UV01 queryEntity, WhereBuilder wb)
        {
            throw new NotImplementedException();
        }

        public TWBAS_PASS FindOne(PRPM_IN306010UV01 queryEntity)
        {
            throw new NotImplementedException();
        }

        public int Update(PRPM_IN303010UV01 updateEntity)
        {
            throw new NotImplementedException();
        }
    }
}
