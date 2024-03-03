using LegalOffice.Domain.Models;
using LegalOffice.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eKancelaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroundTemplateController : ControllerBase
    {
        private readonly IRepository<GroundTemplate> _graoundTemplateRepository;

        public GroundTemplateController(IRepository<GroundTemplate> groundTemplateRepository)
        {
            _graoundTemplateRepository = groundTemplateRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroundTemplate>>> Get()
        {
            return Ok(await _graoundTemplateRepository.GetAll());
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroundTemplate>> Get(int id)
        {
            return Ok(await _graoundTemplateRepository.GetById(id));
        }

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GroundTemplate groundTemplate)
        {
            await _graoundTemplateRepository.Add(groundTemplate);
            return Created();
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] GroundTemplate groundTemplate)
        {
            await _graoundTemplateRepository.Update(groundTemplate);
            return NoContent();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var toDelete = await _graoundTemplateRepository.GetById(id);
            await _graoundTemplateRepository.Delete(toDelete);
            return NoContent();
        }
    }
}
