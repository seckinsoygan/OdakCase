using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Shared
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//override o ile hızlıca yazılabilir.
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Stock> Stock { get; set; }
    }
}
