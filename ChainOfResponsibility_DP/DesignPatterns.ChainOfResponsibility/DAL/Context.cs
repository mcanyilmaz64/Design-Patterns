using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.ChainOfResponsibility.DAL
{
	public class Context:DbContext
	{
		override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				"Server=(localdb)\\mssqllocaldb;Database=DesignPattern1;Trusted_Connection=true;TrustServerCertificate=true;"
			);
		}
		public DbSet<CustomerProcess> CustomerProcesses { get; set; }
	}
}
