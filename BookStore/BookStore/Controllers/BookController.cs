using BookStore.Controllers;
using BookStore.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
	public class BookController : BaseController
	{
		private readonly IBookService bookService;

		public BookController(
			IBookService bookService)
		{
			this.bookService = bookService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[AllowAnonymous]
		public async Task<IActionResult> Details(int id)
		{
			var movie = await bookService.GetBookDetailsByIdAsync(id);

			return View(movie);
		}
	}
}
