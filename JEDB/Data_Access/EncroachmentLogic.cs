using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.Models;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public class EncroachmentLogic
    {
        private EncroachmentDTO _encroachment = new EncroachmentDTO();

        public EncroachmentLogic(EncroachmentDTO encroachmentDTO)
        {
            _encroachment = encroachmentDTO;
        }

        public bool SaveEncroachment()
        {
            Encroachment encroachment = new Encroachment();

            encroachment.Encroachment_ID = _encroachment.EncroachmentID;
            encroachment.Estate_ID = _encroachment.EstateID;
            encroachment.Property_ID = _encroachment.PropertyID;
            encroachment.Name_Of_User = _encroachment.NameOfTheUser;
            encroachment.Address_ID = _encroachment.AddressID;
            encroachment.Telephone_Number = _encroachment.TelephoneNumber;
            encroachment.Size = _encroachment.TelephoneNumber;
            encroachment.Size = _encroachment.Size;
            encroachment.Started_Date = _encroachment.StartedDate;
            encroachment.Remarks = _encroachment.Remarks;
            encroachment.System_User_ID = _encroachment.SystemUserID;
            encroachment.Entry_Date = _encroachment.EntryDate;

            try
            {
                DataAccessLogic.db.Encroachments.InsertOnSubmit(encroachment);
                DataAccessLogic.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }

        }
    }
}
