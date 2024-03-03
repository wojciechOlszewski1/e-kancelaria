using AutoMapper;
using LegalOffice.Domain;
using LegalOffice.Domain.Models;
using LegalOffice.Repository;
using LegalOffice.Services;
using LegalOffice.Services.DTO;
using Microsoft.AspNetCore.Mvc;

namespace eKancelaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaintiffController : ControllerBase
    {
        private readonly IPlaintiffRepository _plantiffRepository;
        private readonly IPlaintiffService _plantiffService;

        public PlaintiffController(IPlaintiffRepository plantiffRepository, IPlaintiffService plantiffService)
        {
            _plantiffRepository = plantiffRepository;
            _plantiffService = plantiffService;
        }
        [HttpGet]
        public async Task<ActionResult<PlaintiffDto>> Get()
        {
            return Ok(await _plantiffService.GetPlaintiffAsync());
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Plantiff>> Get(int id)
        {
            return Ok(await _plantiffRepository.GetWithAddress(id));
        }

        // POST api/<CompanyController>
        [HttpPost("/person")]
        public async Task<ActionResult> Post([FromBody] Person person)
        {
            await _plantiffRepository.Add(person);
            return Created();
        }

        // POST api/<CompanyController>
        [HttpPost("/company")]
        public async Task<ActionResult> PostCompany([FromBody] Company company)
        {
            await _plantiffRepository.Add(company);
            return Created();
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Plantiff person)
        {
            await _plantiffRepository.Update(person);
            return NoContent();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var toDelete = await _plantiffRepository.GetById(id);
            await _plantiffRepository.Delete(toDelete);
            return NoContent();
        }
    }
}
