using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class EncroachmentDTO
    {
        public Guid EncroachmentID { get; set; }
        public string EstateID { get; set; }
        public string PropertyID { get; set; }
        public string NameOfTheUser { get; set; }
        public Guid AddressID { get; set; }
        public string TelephoneNumber { get; set; }
        public string Size { get; set; }
        public DateTime StartedDate { get; set; }
        public string Remarks { get; set; }
        public Guid SystemUserID { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
