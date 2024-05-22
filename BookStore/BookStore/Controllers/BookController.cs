using BookStore.Controllers;
using BookStore.Services.Data.Interfaces;
using BookStore.Web.ViewModels.Books;
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
			bool movieExists = await bookService.ExistsById(id);

			if (!movieExists)
			{
				//add toastr notification
				return NotFound();
			}

			BookDetailsViewModel movie;

			try
			{
				movie = await bookService.GetBookDetailsByIdAsync(id);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Unexpected error has occured, please try again...");
				return StatusCode(500);
			}



			return View(movie);
		}
	}
}
