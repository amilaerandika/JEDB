using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class LeaseDTO
    {

        public Guid LeaseId { get; set; }
        public string EstateId { get; set; }
        public string PropertyId { get; set; }
        public string TypeOfLease { get; set; }
        public decimal RentalValue { get; set; }
        public bool LeaseStatus { get; set; }
        public Guid SystemUserId { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
