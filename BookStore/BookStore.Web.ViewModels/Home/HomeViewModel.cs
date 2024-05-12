using BookStore.Data.Models;
using BookStore.Services.Mapping;
using BookStore.Web.ViewModels.Books;

namespace BookStore.Web.ViewModels.Home
{
	public class HomeViewModel
    {
        public HomeViewModel()
        {
            NewBooks = new HashSet<BookViewModel>();
			BestSellers = new HashSet<BookViewModel>();
			DiscountedBooks = new HashSet<BookViewModel>();
        }

        public ICollection<BookViewModel> NewBooks { get; set; } = null!;

        public ICollection<BookViewModel> BestSellers { get; set; } = null!;

        public ICollection<BookViewModel> DiscountedBooks { get; set; } = null!;
    }
}
