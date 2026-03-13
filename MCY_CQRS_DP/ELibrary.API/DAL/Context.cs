using Microsoft.EntityFrameworkCore;

namespace ELibrary.API.DAL
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseSqlServer(
			"Server=(localdb)\\mssqllocaldb;Database=CQRSLibrary;Trusted_Connection=true;TrustServerCertificate=true;"
		);

		}
		public DbSet<Book> Books { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Purchase> Purchases { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
