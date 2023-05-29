using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Organization.Entities;

namespace Organization.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts)
        : base(opts) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("postgres");

        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organization.Entities.Organization> Organizations { get; set; }
    }
}