using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.CQRS.DAL
{
    public class Context :DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=DesignPattern2;Trusted_Connection=true;TrustServerCertificate=true;"
        );
        }
        public DbSet<Product> Products { get; set; }
    }
}
