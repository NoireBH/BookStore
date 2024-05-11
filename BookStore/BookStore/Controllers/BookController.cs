using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    public class BookController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
