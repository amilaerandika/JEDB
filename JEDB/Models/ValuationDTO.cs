using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class ValuationDTO
    {

        public Guid ValuationId { get; set; }
        public string EstateId { get; set; }
        public string PropertyId { get; set; }
        public DateTime ValuationDate { get; set; }
        public decimal PreviousValue { get; set; }
        public decimal AmendedValue { get; set; }
        public bool IsActive { get; set; }
        public string Remarks { get; set; }
        public Guid DocumentId { get; set; }
        public Guid SystemUserId { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
