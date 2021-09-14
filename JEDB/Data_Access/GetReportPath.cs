using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Data_Access
{
    public static class GetReportPath
    {
        public static string GetReportPathFromDB()
        {
            return @"C:\Users\amila\Desktop\JEDB\JEDB\Reports\";
        }

        public static List<string> GetUserNamePassword()
        {
            List<string> userData = new List<string>();

            userData.Add("sa");
            userData.Add("1324");
            return userData;
        }
    }
}
