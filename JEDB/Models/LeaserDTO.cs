using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class LeaserDTO
    {
        public Guid LeaserId { get; set; }
        public string Name { get; set; }
        public Guid PhoneNumberId { get; set; }
        public string Email { get; set; }
        public Guid AddressId { get; set; }
        public Guid SystemUserId { get; set; }
        public DateTime EntryDate { get; set; }

    }
}
