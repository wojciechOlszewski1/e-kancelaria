using LegalOffice.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOffice.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly LegalOfficeDbContext _context;

        public Repository(LegalOfficeDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public Task Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChangesAsync();
        }

        public Task Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return _context.SaveChangesAsync();
        }

        public Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChangesAsync();
        }
    }
}
