using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
