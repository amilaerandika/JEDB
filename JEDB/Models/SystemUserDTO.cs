using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class SystemUserDTO
    {
		public Guid SystemUserId { get; set; }
        public string SystemUserName { get; set; }
        public string Password { get; set; }
        public Guid AddressId { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { get; set; }
        public Guid EntryDate { get; set; }
    }
}
