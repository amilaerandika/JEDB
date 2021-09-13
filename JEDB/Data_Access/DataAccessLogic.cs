using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEDB.JEDB_Data;


namespace JEDB.Data_access
{
    public static class DataAccessLogic
    {
        public static JEDBContextDataContext db = new JEDBContextDataContext();

        public static void SaveChangesToTheDB()
        {
            db.SubmitChanges();
        }
    }
}
