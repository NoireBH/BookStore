using BookStore.Services.Data;
using BookStore.Services.Data.Interfaces;
using BookStore.Web.Controllers;
using BookStore.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IBookService bookService;

		public HomeController(ILogger<HomeController> logger, BookService bookService)
		{
			_logger = logger;
			this.bookService = bookService;
		}

        [AllowAnonymous]
        public IActionResult Index()
		{

			return View();
		}

        [AllowAnonymous]
        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}