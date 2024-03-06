using LegalOffice.Domain.Models;
using LegalOffice.Repository;
using LegalOffice.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eKancelaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LawsuitController : ControllerBase
    {
        private readonly ILawsuitRepository _lawsuitRepository;
        private readonly ILawsuitService _lawsuitService;

        public LawsuitController(ILawsuitRepository lawsuitRepository, ILawsuitService lawsuitService)
        {
            _lawsuitRepository = lawsuitRepository;
            _lawsuitService = lawsuitService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var lawsuit = new Lawsuit
            {
                Plantiffs = new[] { new Person {
                    IsForeigner = false,
                    LacksIdentificationNumbers = false,
                    Representation = 1,
                    PartyType = 1,
                    Type = 1,
                    Tin = "1234567890",
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Pesel="94032552149",
                    Address = new Address
                    {
                        Country = "Polska",
                        Street = "ul. Boczna Lubomelskiej",
                        HouseNumber = "13",
                        PostalCode = "20070",
                        Postal="test",
                        City = "Lublin"
                    },
                    Name = "Jan Kowalski" } },
                Defendant = new[] { new Person {
                    IsForeigner = false,
                    LacksIdentificationNumbers = false,
                    Representation = 1,
                    PartyType = 1,
                    Type = 1,
                    Tin = "1234567890",
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Pesel="94032552149",
                    Address = new Address
                    {
                        Street = "ul. Boczna Lubomelskiej",
                        HouseNumber = "13",
                        PostalCode = "20070",
                        City = "Lublin",
                        Country= "Polska", Postal="test",

                    },
                    Name = "Jan Kowalski" } },
                Submitter = new Submitter
                {
                    Proxy = 1,
                    Basis = "Zarządca",
                    Name="Radca",
                    Address = new Address
                    {
                        Street = "ul. Boczna Lubomelskiej",
                        HouseNumber = "13",
                        PostalCode = "20070",
                        City = "Lublin",
                        Country = "Polska",
                        Postal = "test",
                    },
                    Person = new PersonForCompany
                    {
                        FirstName = "Jan",
                        LastName = "Kowalski",
                        Pesel = "94032552149",
                        Name = "Jan Kowalski"
                    },
                },
                Claims = new[] { new Claim
                {
                    Number = 1,
                    Description = "Opis",
                    Currency = Currency.PLN,
                    Value = 1000,
                    InterestRate = 1,
                    Proofs = new sbyte[]{0},
                    Jointly=0,
                    Type=0,
                    DueDate="2021-12-31",
                }
                },
                Ground = "Podstawa",
                AmountOfControversy = 1000,
                Fee = new Fee
                {
                    Value = 100,
                },
                Cost = new Cost
                {
                    Value = 100,
                },
                RefundAccount = new RefundAccount
                {
                    RefundAccountNumber = "83814210209140140948346931",
                    AccountOwner = "Jan Kowalski",
                }
            };
           await  _lawsuitRepository.Add(lawsuit);
            var lawsuits = await  _lawsuitRepository.GetAll();
            return Ok(lawsuits);
        }

        // GET api/<LawsuitController>/5
        [HttpGet("{id}")]
        public async Task Get(int id)
        {
          await _lawsuitService.SendLawsuit(id);
           
        }

        // POST api/<LawsuitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LawsuitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LawsuitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
