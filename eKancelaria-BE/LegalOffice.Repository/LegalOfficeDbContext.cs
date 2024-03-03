using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalOffice.Domain.Models;

namespace LegalOffice.Repository
{
    public class LegalOfficeDbContext : DbContext
    {
        public LegalOfficeDbContext(DbContextOptions<LegalOfficeDbContext> options) : base(options)
        {
        }

        public DbSet<Plantiff> Plantiffs { get; set; }
        public DbSet<GroundTemplate> GroundTemplates { get; set; }
        public DbSet<Lawsuit> Lawsuits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Plantiff>()
            .HasDiscriminator<int>("Type")
            .HasValue<Person>(1)
            .HasValue<Company>(2);
        }

    }
}
