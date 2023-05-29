using Microsoft.EntityFrameworkCore;
using Organization.Entities;
using Organization.Repository.Services;

namespace Organization.Repository
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AdressOptions());
            modelBuilder.ApplyConfiguration(new EmployeeOptions());
            modelBuilder.ApplyConfiguration(new CompanyOptions());
        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}