using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class ReminderDTO
    {
        public Guid ReminderID { get; set; }
        public DateTime AddedDate { get; set; }
        public string ReminderType { get; set; }
        public Guid DocumentID { get; set; }
        public bool IsReminderActive { get; set; }
        public bool IsReminderSent { get; set; }
        public decimal ReminderValue { get; set; }
        public Guid SystemUserID { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
