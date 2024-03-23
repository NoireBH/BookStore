﻿using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
	public class BookStoreDbContext : DbContext
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

