using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Domain.Models
{
    public class Lawsuit
    {
        public Lawsuit()
        {
            Addressee = new Addressee
            {
                Name = "Sąd Rejonowy Lublin-Zachód w Lublinie",
                Division = "VI Wydział Cywilny",
                Address = new Address
                {
                    Street = "ul. Boczna Lubomelskiej",
                    HouseNumber = "13",
                    PostalCode = "20070",
                    City = "Lublin"
                }
            }; 
        }

        public int Id { get; set; }
        public Addressee Addressee { get; }

        public IEnumerable<Plantiff> Plantiffs { get; set; }
        public IEnumerable<Plantiff> Defendant { get; set; }
        public Submitter Submitter { get; set; }
        public IEnumerable<Claim> Claims { get; set; }
        public string Ground { get; set; }
        public decimal AmountOfControversy { get; set; }
        public Fee Fee { get; set; }

        public Cost Cost { get; set; }
        public RefundAccount RefundAccount { get; set; }
    }
}
