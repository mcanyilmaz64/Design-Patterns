using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.DAL
{
    public class Context: IdentityDbContext<AppUser,AppRole,int>
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                 "Server=(localdb)\\mssqllocaldb;Database=DesignPattern4;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
    }
}
