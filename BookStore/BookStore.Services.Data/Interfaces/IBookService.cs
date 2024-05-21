using BookStore.Web.ViewModels.Books;
using BookStore.Web.ViewModels.Home;

namespace BookStore.Services.Data.Interfaces
{
    public interface IBookService
    {
        Task<ICollection<BookViewModel>> GetAllBooksAsync();

        Task<bool> ExistsById(int id);

        Task<ICollection<BookViewModel>> GetNewestBooksAsync();

        Task<HomeViewModel> GetNewestBestsellersAndDiscountedBooksAsync();

        Task<BookDetailsViewModel> GetBookDetailsByIdAsync(int id);
    }
}
