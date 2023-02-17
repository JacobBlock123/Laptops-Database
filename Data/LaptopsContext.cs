using Microsoft.EntityFrameworkCore;
using MVC_Final_Assignment.Models;

namespace MVC_Final_Assignment.Data
{
    public class LaptopsContext : DbContext
    {
        public DbSet<Laptop> Laptops { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public LaptopsContext(DbContextOptions<LaptopsContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Laptops;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
