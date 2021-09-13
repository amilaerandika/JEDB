using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class DuePaymentDTO
    {
        public Guid DuePaymentId { get; set; }
        public DateTime DueDate { get; set; }
        public string PropertyId { get; set; }
        public string EstateId { get; set; }
        public string AgreementId { get; set; }
        public string EstateName { get; set; }
        public decimal DueValue { get; set; }
        public Guid LeaserId { get; set; }
        public string PayoutStatus { get; set; }
        public DateTime EntryDate { get; set; }
        public Guid SystemUserId { get; set; }
    }
}
