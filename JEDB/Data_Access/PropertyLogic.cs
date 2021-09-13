using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.Models;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public class PropertyLogic
    {
        private PropertyDTO _property = new PropertyDTO();

        public PropertyLogic(PropertyDTO propertyDTO)
        {
            _property = propertyDTO;
        }

        public bool SaveProperty()
        {
            Property property = new Property();

            property.Property_ID = _property.PropertyId;
            property.Estate_ID = _property.EstateId;
            property.Property_Type = _property.PropertyType;
            property.Size = _property.Size;
            property.Plan_Number = _property.PlanNumber;
            property.System_User_ID = _property.SystemUserId;
            property.Entry_Date = _property.EntryDate;

            try
            {
                DataAccessLogic.db.Properties.InsertOnSubmit(property);
                DataAccessLogic.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }
        }
    }
}
