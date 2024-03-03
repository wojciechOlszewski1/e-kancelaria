using LegalOffice.Domain.Models;
using LegalOffice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Repository
{
    public interface ILawsuitRepository : IRepository<Lawsuit>
    {
   
    }

    internal class LawsuitRepository :Repository<Lawsuit>, ILawsuitRepository
    {
        private readonly LegalOfficeDbContext _context;
        public LawsuitRepository(LegalOfficeDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
