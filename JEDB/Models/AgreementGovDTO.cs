using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEDB.Models
{
    public class AgreementGovDTO
    {
        public string AgreementNo { get; set; }
        public string AgreementName { get; set; }
        public DateTime GazzateDate { get; set; }
        public string TypeOfAgreement { get; set; }
        public string Remarks { get; set; }
        public Guid DocumentId { get; set; }
        public Guid SystemUserId { get; set; }

    }
}
