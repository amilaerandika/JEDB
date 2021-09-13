using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class AddressDTO
    {
        public Guid AddressID { get; set; }
        public string FromTable { get; set; }
        public string OriginDescription { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LineThree { get; set; }
        public string LineFour { get; set; }
        public string LineFive { get; set; }
        public string LineSix { get; set; }
        public string RestOfTheAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public Guid SystemUserID { get; set; }
    }
}
