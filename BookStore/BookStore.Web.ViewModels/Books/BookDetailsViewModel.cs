using AutoMapper;
using BookStore.Data.Models;
using BookStore.Services.Mapping;
using BookStore.Web.ViewModels.Authors;
using BookStore.Web.ViewModels.Genres;

namespace BookStore.Web.ViewModels.Books
{
	public class BookDetailsViewModel : IMapFrom<Book>, IHaveCustomMappings
	{
        public BookDetailsViewModel()
        {
			Authors = new HashSet<AuthorViewModel>();
			Genres = new HashSet<GenreViewModel>();
			SameAuthorBooks = new HashSet<BookViewModel>();
			SimularBooks = new HashSet<BookViewModel>();

		}

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

		public ICollection<BookViewModel> SameAuthorBooks { get; set; } = null!;

		public ICollection<BookViewModel> SimularBooks {  get; set; } = null!;

		public void CreateMappings(IProfileExpression configuration)
		{
			configuration.CreateMap<Book, BookDetailsViewModel>()
			   .ForMember(bd => bd.PublisherName, cfg => cfg
				   .MapFrom(b => b.Publisher.Name));
		}
	}
}
