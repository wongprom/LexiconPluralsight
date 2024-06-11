using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageAp.Entities;

namespace WiredBrainCoffee.StorageAp.Data
{
    public class StorageApDbContext : DbContext
    {
        public DbSet<Employee>Employees => Set<Employee>();
        public DbSet<Organization>Organizations => Set<Organization>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageApDb");
        }
    }
}
