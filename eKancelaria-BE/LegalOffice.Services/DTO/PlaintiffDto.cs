using LegalOffice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Services.DTO
{
    public class PlaintiffDto
    { 
       public IEnumerable<Company> Companies { get; set; }
       public IEnumerable<Person> Persons { get; set; }
    }
}
