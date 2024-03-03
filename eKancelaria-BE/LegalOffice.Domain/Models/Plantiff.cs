using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public abstract class Plantiff
    {
        public int Id { get; set; }
        public string? ForeignerString { get; } = "Obywatelstwo polskie";

        public bool IsForeigner { get; set; }

        public bool LacksIdentificationNumbers { get; set; }

        public sbyte Representation { get; set; }

        public int PartyType { get; set; }
        public int Type { get; set; }

        public string? Tin { get; set; }

        public Address Address { get; set; }

        public string AccountNumber { get; set; }

    }
}
