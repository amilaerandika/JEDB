using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class AgreementLeaseDTO
    {
        public string AgreementId { get; set; }
        public Guid LeaserId { get; set; }
        public string PropertyId { get; set; }
        public string EstateId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Duration { get; set; }
        public decimal AgreementValue { get; set; }
        public Guid SystemUserId { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
