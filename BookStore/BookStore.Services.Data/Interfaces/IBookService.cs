using BookStore.Web.ViewModels.Books;

namespace BookStore.Services.Data.Interfaces
{
    public interface IBookService
    {
        Task<ICollection<BookViewModel>> GetAllBooks();

        Task<ICollection<BookViewModel>> GetNewestBooks();
    }
}
