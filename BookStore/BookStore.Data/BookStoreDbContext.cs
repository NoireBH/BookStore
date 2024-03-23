using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
	public class BookStoreDbContext : DbContext
	{
		public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
			: base(options)
		{

		}

		


		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}

