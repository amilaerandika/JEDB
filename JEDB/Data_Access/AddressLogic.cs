using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.Models;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public class AddressLogic
    {
        private AddressDTO _address = new AddressDTO();

        public AddressLogic(AddressDTO addressDTO)
        {
            _address = addressDTO;
        }

        public Guid SaveAddress()
        {
            Address address = new Address();
            address.Address_ID = Guid.NewGuid();
            address.From_Table = _address.FromTable;
            address.Origin_Description = _address.OriginDescription;
            address.Line_One = _address.LineOne;
            address.Line_Two = _address.LineTwo;
            address.Line_Three = _address.LineThree;
            address.Line_Four = _address.LineFour;
            address.Line_Five = _address.LineFive;
            address.Line_Six = _address.LineSix;
            address.Rest_Of_The_Address = _address.RestOfTheAddress;
            address.System_User_ID = _address.SystemUserID;

            try 
            {
                DataAccessLogic.db.Addresses.InsertOnSubmit(address);
                DataAccessLogic.SaveChangesToTheDB();
                return address.Address_ID;
            }
            catch 
            {
                return Guid.Empty;
            }
        }
    }
}
