using LegalOffice.Domain;
using LegalOffice.Domain.Models;
using LegalOffice.Repository;
using LegalOffice.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Services
{
    public interface IPlaintiffService
    {
        public Task<PlaintiffDto> GetPlaintiffAsync();
    }


    public class PlaintiffService : IPlaintiffService
    {
        private readonly IPlaintiffRepository _plantiffRepository;


        public PlaintiffService(IPlaintiffRepository plaintiffRepository)
        {
            _plantiffRepository = plaintiffRepository;
        }

        public async Task<PlaintiffDto> GetPlaintiffAsync()
        {
            var res = await _plantiffRepository.GetAllWith();

            var plaintiff = new PlaintiffDto
            {
                Companies = res.OfType<Company>(),
                Persons = res.OfType<Person>(),
            };
            return plaintiff;
        }
    }
}
