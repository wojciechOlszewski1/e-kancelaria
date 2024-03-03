using LegalOffice.Domain;
using LegalOffice.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Repository
{
    public interface IPlaintiffRepository : IRepository<Plantiff>
    {
        public Task<IEnumerable<Plantiff>> GetAllWith();
        public Task<Plantiff> GetWithAddress(int id);
    }

    public class PlaintiffRepository : Repository<Plantiff>, IPlaintiffRepository
    {
        private readonly LegalOfficeDbContext _context;
        public PlaintiffRepository(LegalOfficeDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Plantiff>> GetAllWith()
        {
            var res = await _context.Plantiffs.ToListAsync();
            return res;
        }

        public async Task<Plantiff> GetWithAddress(int id)
        {
            var res = await _context.Plantiffs.Include(p => p.Address).SingleAsync(p => p.Id == id);
            return res;
        }
    }
}
