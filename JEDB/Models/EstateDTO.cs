using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class EstateDTO
    {
        public string EstateId { get; set; }
        public string EstateName { get; set; }
        public string Size { get; set; }
        public string LeaseExclusiveSize { get; set; }
        public string District { get; set; }
        public string DistrictSecratariat { get; set; }
        public string AgreementGov { get; set; }
        public Guid AddressId { get; set; }
        public Guid SystemUserId { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
