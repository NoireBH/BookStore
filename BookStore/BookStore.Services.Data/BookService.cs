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

		public Task<bool> ExistsById(int id)
		{
			return context.Books.AnyAsync(x => x.Id == id);
		}

		public async Task<ICollection<BookViewModel>> GetAllBooksAsync()
		{
			var books = await context.Books
				.To<BookViewModel>()
				.ToArrayAsync();

			return books;
		}

		public async Task<BookDetailsViewModel> GetBookDetailsByIdAsync(int id)
		{
			var book = await context.Books
				.Where(b => b.Id == id)
				.To<BookDetailsViewModel>()
				.FirstOrDefaultAsync();

			var sameAuthorBooks = await context.Books
				.Where(b => b.Authors
				.Any(a => book!.Authors.Any(a2 => a2.Id == a.Id)))
				.OrderByDescending(x => x.Id)
				.Take(9)
				.To<BookViewModel>()
				.ToArrayAsync();


			var simularBooks = await context.Books
				.Where(b => b.Genres
				.Any(g => book!.Genres
					.Any(g2 => g2.Id == g.Id)))
				.OrderByDescending(x => x.Id)
				.Take(9)
				.To<BookViewModel>()
				.ToArrayAsync();

			book!.SameAuthorBooks = sameAuthorBooks;
			book!.SimularBooks = simularBooks;


			return book!;
		}

		public async Task<HomeViewModel> GetNewestBestsellersAndDiscountedBooksAsync()
		{
			var newestBooks = await context.Books
				.OrderByDescending(x => x.Id)
				.Take(9)
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

		public async Task<ICollection<BookViewModel>> GetNewestBooksAsync()
		{
			var books = await context.Books
				.Take(3)
				.To<BookViewModel>()
				.ToArrayAsync();

			return books;
		}
	}
}
