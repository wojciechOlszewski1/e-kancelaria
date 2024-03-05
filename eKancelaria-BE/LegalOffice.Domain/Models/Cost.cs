using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public class Cost
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        public sbyte? Adjudication { get; set; }

        public sbyte? AccordingToStandards { get; set; }

        public string? Description { get; set; }
    }
}
