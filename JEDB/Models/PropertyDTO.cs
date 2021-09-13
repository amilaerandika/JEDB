using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class PropertyDTO
    {
        public string PropertyId { get; set; }
        public string EstateId { get; set; }
        public string PropertyType { get; set; }
        public string Size { get; set; }
        public string PlanNumber { get; set; }
        public Guid SystemUserId { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
