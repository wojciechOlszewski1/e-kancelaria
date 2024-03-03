using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public class RefundAccount
    {
        public int Id { get; set; }
        public string RefundAccountNumber { get; set; }

        public string AccountOwner { get; set; }
    }
}
