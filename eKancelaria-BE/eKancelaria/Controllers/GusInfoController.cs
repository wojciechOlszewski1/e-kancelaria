using GusApi.Models;
using LegalOffice.Domain.Models;
using LegalOffice.Domain;
using Microsoft.AspNetCore.Mvc;
using GusApi;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eKancelaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GusInfoController : ControllerBase
    {
        private readonly IObslugaGus _gus;

        public GusInfoController(IObslugaGus gus)
        {
            _gus = gus;
            gus.ApiKey = "111";
        }

        [HttpGet("{tin}")]
        public ActionResult<PodmiotGus> Get(string tin)
        {
            return Ok(_gus.PobierzDanePodmiotu(tin));
        }
    }
}
