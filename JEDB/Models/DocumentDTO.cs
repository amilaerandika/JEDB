using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class DocumentDTO
    {
		public Guid DocumentID { get; set; }
        public string EstateID { get; set; }
        public string PropertyID { get; set; }
        public string AgreementLeaseID { get; set; }
        public string AgreementGOVID { get; set; }
        public string DocumentType { get; set; }
        public string DocumentName { get; set; }
        public string FileLocation { get; set; }
        public string BackupLocation { get; set; }
        public string Remarks { get; set; }
        public Guid SystemUserId { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
