using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public InterestPeriod[]? InterestPeriods { get; set; }

        public sbyte[] Proofs { get; set; }

        public int Number { get; set; }

        public decimal Value { get; set; }

        public Currency Currency { get; set; }

        public string Description { get; set; }

        public sbyte InterestRate { get; set; }

        public sbyte Jointly { get; set; }

        public sbyte Type { get; set; }

        public string DueDate { get; set; }
    }
}
