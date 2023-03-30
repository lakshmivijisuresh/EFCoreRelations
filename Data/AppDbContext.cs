using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationshipss.Data
{
	public class AppDbContext :DbContext
	{
		internal List<Product> Products;

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		public DbSet <Category> Categories { get; set; }	

		public DbSet<Product> Productss { get; set; }

		public DbSet<Size> Sizes { get; set; }

		public DbSet<Color> Colors { get; set; }
	}
}
