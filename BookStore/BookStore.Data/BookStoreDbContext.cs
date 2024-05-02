using BookStore.Data.Configurations;
using BookStore.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
	public class BookStoreDbContext : IdentityDbContext
	{
		public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
			: base(options)
		{

		}

		public DbSet<Author> Authors { get; set; } = null!;

		public DbSet<Book> Books { get; set; } = null!;

		public DbSet<Character> Characters { get; set; } = null!;

		public DbSet<Genre> Genres { get; set; } = null!;

		public DbSet<Publisher> Publishers { get; set; } = null!;

		public DbSet<Order> Orders { get; set; } = null!;



		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new PublisherEntityConfiguration());
			builder.ApplyConfiguration(new BookEntityConfiguration());
			

			base.OnModelCreating(builder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}

