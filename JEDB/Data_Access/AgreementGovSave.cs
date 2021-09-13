using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.Models;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public class AgreementGovSave
    {
        private AgreementGovDTO _agreementGov = new AgreementGovDTO();
        public AgreementGovSave(AgreementGovDTO agreementGovDTO)
        {
            _agreementGov = agreementGovDTO;
        }

        public bool SaveAgreementWithGov()
        {
            Agreement_Gov agreement_Gov = new Agreement_Gov();

            agreement_Gov.Agreement_No = _agreementGov.AgreementNo;
            agreement_Gov.Name = _agreementGov.AgreementName;
            agreement_Gov.Gazzate_Date = _agreementGov.GazzateDate;
            agreement_Gov.Type_Of_Agreement = _agreementGov.TypeOfAgreement;
            agreement_Gov.Remarks = _agreementGov.Remarks;
            agreement_Gov.Document_ID = _agreementGov.DocumentId;
            agreement_Gov.System_User_ID = _agreementGov.SystemUserId;
            agreement_Gov.Entry_Date = DateTime.Now;

            try
            {
                DataAccessLogic.db.Agreement_Govs.InsertOnSubmit(agreement_Gov);
                DataAccessLogic.SaveChangesToTheDB();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
