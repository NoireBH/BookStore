using BookStore.Controllers;
using BookStore.Services.Data.Interfaces;
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

		public Task<IActionResult> Details(int id)
		{
			var movie = bookService

			return View();
		}
	}
}
