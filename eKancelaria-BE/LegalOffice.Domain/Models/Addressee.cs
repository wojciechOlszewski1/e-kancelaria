using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public class Addressee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Division { get; set; }
        public Address Address { get; set; }
    }
}
