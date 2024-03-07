using LegalOffice.Domain.Models;
using LegalOffice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LegalOffice.Repository
{
    public interface ILawsuitRepository : IRepository<Lawsuit>
    {
       new Task<IEnumerable<Lawsuit>> GetAll();
        Task<Lawsuit> Get(int id);
    }

    public class LawsuitRepository : Repository<Lawsuit>, ILawsuitRepository
    {
        private readonly LegalOfficeDbContext _context;
        public LawsuitRepository(LegalOfficeDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<Lawsuit> Get(int id)
        {
            return _context.Lawsuits
                .Include(l => l.Plantiffs).ThenInclude(p => p.Address)
                .Include(l=>l.Defendant).ThenInclude(p => p.Address)
                .Include(l => l.Submitter).ThenInclude(p => p.Address)
                .Include(l=>l.Submitter).ThenInclude(p => p.Person)
                .Include(l => l.Fee)
                .Include(l => l.Cost)
                .Include(l => l.RefundAccount)
                .Include(l => l.Claims)
                .SingleAsync(l => l.Id == id);
        }

        new public async Task<IEnumerable<Lawsuit>> GetAll()
        {
            var t= await _context.Lawsuits
                .Include(l => l.Plantiffs)
                .Include(l => l.Submitter)
                .Include(l => l.Fee)
                .Include(l => l.Cost)
                .Include(l => l.RefundAccount)
                .Include(l => l.Claims).ToListAsync();

            return t;
        }
    }
}
