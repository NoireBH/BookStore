using BookStore.Web.ViewModels.Books;
using BookStore.Web.ViewModels.Home;

namespace BookStore.Services.Data.Interfaces
{
    public interface IBookService
    {
        Task<ICollection<BookViewModel>> GetAllBooks();

        Task<ICollection<BookViewModel>> GetNewestBooks();

        Task<HomeViewModel> GetNewestBestsellersAndDiscountedBooks();
    }
}
