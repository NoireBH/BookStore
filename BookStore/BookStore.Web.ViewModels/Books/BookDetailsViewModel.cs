using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Web.ViewModels.Authors;
using BookStore.Web.ViewModels.Genre;

namespace BookStore.Web.ViewModels.Books
{
	public class BookDetailsViewModel
	{
		public int Id { get; set; }

		public string Title { get; set; } = null!;

		public string Description { get; set; } = null!;

		public int YearOfRelease { get; set; }

		public double Price { get; set; }

		public int PageCount { get; set; }

		public int Discount { get; set; }

		public string ImagePath { get; set; } = null!;

		public string PublisherName { get; set; } = null!;

		public ICollection<AuthorViewModel> Authors { get; set; } = null!;

		public ICollection<GenreViewModel> Genres { get; set; } = null!;
	}
}
