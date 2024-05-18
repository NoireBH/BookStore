using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Data.Models;

namespace BookStore.Data.Configurations
{
	public class GenreEntityConfiguration : IEntityTypeConfiguration<Genre>
	{
		public void Configure(EntityTypeBuilder<Genre> builder)
		{
			builder.HasData(SeedGenres());

			builder
			.HasMany(b => b.Books)
			.WithMany(a => a.Genres)
			.UsingEntity(
				 ba => ba.HasData(
					 new { BooksId = 1, GenresId = 6 },
					 new { BooksId = 1, GenresId = 8 },
					 new { BooksId = 2, GenresId = 5 },
					 new { BooksId = 2, GenresId = 6 },
					 new { BooksId = 2, GenresId = 13 },
					 new { BooksId = 3, GenresId = 5 },
					 new { BooksId = 3, GenresId = 11 },
					 new { BooksId = 3, GenresId = 12 },
					 new { BooksId = 4, GenresId = 6 },
					 new { BooksId = 5, GenresId = 7 },
					 new { BooksId = 5, GenresId = 12 },
					 new { BooksId = 5, GenresId = 13 },
					 new { BooksId = 6, GenresId = 6 },
					 new { BooksId = 7, GenresId = 6 },
					 new { BooksId = 8, GenresId = 6 },
					 new { BooksId = 9, GenresId = 6 },
					 new { BooksId = 10, GenresId = 6 },
					  new { BooksId = 11, GenresId = 6 },
					 new { BooksId = 12, GenresId = 6 },
					 new { BooksId = 13, GenresId = 6 },
					 new { BooksId = 14, GenresId = 6 },
					 new { BooksId = 15, GenresId = 6 },
					 new { BooksId = 16, GenresId = 6 },
					 new { BooksId = 17, GenresId = 14 },
					 new { BooksId = 17, GenresId = 16 },
					 new { BooksId = 18, GenresId = 14 },
					 new { BooksId = 18, GenresId = 5 },
					 new { BooksId = 19, GenresId = 14 },
					 new { BooksId = 19, GenresId = 16 },
					 new { BooksId = 19, GenresId = 8 },
					 new { BooksId = 20, GenresId = 15 },
					 new { BooksId = 20, GenresId = 16 },
					 new { BooksId = 20, GenresId = 7 },
					 new { BooksId = 20, GenresId = 5 }
					 ));
		}

		private Genre[] SeedGenres()
		{
			var genres = new HashSet<Genre>();

			Genre genre;

			genre = new Genre()
			{
				Id = 1,
				Name = "Satire"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 2,
				Name = "Poetry"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 3,
				Name = "Comedy"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 4,
				Name = "Crime"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 5,
				Name = "Drama"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 6,
				Name = "Fantasy"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 7,
				Name = "Sci-Fi"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 8,
				Name = "Horror"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 9,
				Name = "Romance"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 10,
				Name = "History"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 11,
				Name = "Mystery"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 12,
				Name = "Thriller"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 13,
				Name = "Adventure"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 14,
				Name = "Manga"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 15,
				Name = "Light-Novel"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 16,
				Name = "Action"
			};

			genres.Add(genre);

			return genres.ToArray();
		}

	}
}
