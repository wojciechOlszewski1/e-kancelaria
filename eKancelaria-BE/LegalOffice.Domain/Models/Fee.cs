using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public class Fee
    {
        public int Id { get; set; }
        public bool ReducedCourtFee { get; set; }

        public bool ReducedCourtFeeSpecified { get; set; }

        public decimal Value { get; set; }

        public sbyte Exemption { get; set; }

        public sbyte Adjudication { get; set; }

        public ulong Identifier { get; set; }

        public bool IdentifierSpecified { get; set; }
    }
}
