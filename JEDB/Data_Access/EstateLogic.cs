using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.Models;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public class EstateLogic
    {
        private EstateDTO _estate = new EstateDTO();
        public EstateLogic(EstateDTO estateDTO)
        {
            _estate = estateDTO;
        }

        public bool SaveEstate()
        {
            Estate estate = new Estate();

            estate.Estate_ID = _estate.EstateId;
            estate.Estate_Name = _estate.EstateName;
            estate.Size = _estate.Size;
            estate.Lease_Exclusive_Size = _estate.LeaseExclusiveSize;
            estate.District = _estate.District;
            estate.District_Secratariat = _estate.DistrictSecratariat;
            estate.Agreement_GOV = _estate.AgreementGov;
            estate.Address_ID = _estate.AddressId;
            estate.System_User_ID = _estate.SystemUserId;
            estate.Entry_Date = _estate.EntryDate;

            try
            {
                DataAccessLogic.db.Estates.InsertOnSubmit(estate);
                DataAccessLogic.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }

        }
    }
}
