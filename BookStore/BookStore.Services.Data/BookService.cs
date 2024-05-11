using BookStore.Data;
using BookStore.Services.Data.Interfaces;
using BookStore.Web.ViewModels.Books;
using BookStore.Services.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Services.Data
{
    public class BookService : IBookService
    {
        private readonly BookStoreDbContext context;

        public BookService(BookStoreDbContext context)
        {
            this.context = context;
        }

        public async Task<ICollection<BookViewModel>> GetAllBooks()
        {
            var books = await context.Books
                .To<BookViewModel>()
                .ToArrayAsync();

            return books;
        }

        public async Task<ICollection<BookViewModel>> GetNewestBooks()
        {
            var books = await context.Books
                .Take(3)
                .To<BookViewModel>()
                .ToArrayAsync();

            return books;
        }
    }
}
