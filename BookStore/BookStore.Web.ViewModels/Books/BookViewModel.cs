using AutoMapper;
using BookStore.Data.Models;
using BookStore.Services.Mapping;
using BookStore.Web.ViewModels.Authors;

namespace BookStore.Web.ViewModels.Books
{
    public class BookViewModel : IMapFrom<Book> , IHaveCustomMappings
    {
        public BookViewModel()
        {
            Authors = new HashSet<AuthorViewModel>();
        }

        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public double Price { get; set; }

        public double DiscountedPrice { get; set; }

        public string ImagePath { get; set; } = null!;

        public virtual ICollection<AuthorViewModel> Authors { get; set; } = null!;

		public void CreateMappings(IProfileExpression configuration)
		{
            configuration.CreateMap<Book, BookViewModel>()
                .ForMember(b => b.DiscountedPrice, cgf => cgf
                    .MapFrom(b => b.Price * (b.Discount / 100)));
		}
	}
}
