using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public class Submitter
    {
        public int Id { get; set; }
        public PersonForCompany Person { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public sbyte Proxy { get; set; }

        public string Basis { get; set; }
    }
}
