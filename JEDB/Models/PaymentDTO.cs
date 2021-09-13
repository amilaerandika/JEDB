using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class PaymentDTO
    {
        public Guid PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid ReminderID { get; set; }
        public Guid DuePaymentID { get; set; }
        public decimal PaymentValue { get; set; }
        public string PaymentType { get; set; }
        public string PaidByName { get; set; }
        public string IdentificationDetails { get; set; }
        public string PaymentRemarks { get; set; }
        public Guid SystemUserID { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
