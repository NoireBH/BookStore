using BookStore.Data;
using BookStore.Services.Data.Interfaces;
using BookStore.Web.ViewModels.Books;
using BookStore.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using BookStore.Web.ViewModels.Home;

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

        public async Task<ICollection<HomeViewModel>> GetNewestBestsellersAndDiscountedBooks()
        {
            var newestBooks = await context.Books
                .Take(3)
                .To<BookViewModel>()
                .ToArrayAsync();

            var bestsellers = await context.Books
                .OrderByDescending(x => x.SoldCopies)
                .Take(5)
                .To<BookViewModel>()
                .ToArrayAsync();

            var discountedBooks = await context.Books
                .Where(x => x.Discount > 0)
                .Take(5)
                .To<BookViewModel>()
                .ToArrayAsync();

            var books = new HomeViewModel()
            {
                NewBooks = newestBooks,
                BestSellers = bestsellers,
                DiscountedBooks = discountedBooks
            };

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
