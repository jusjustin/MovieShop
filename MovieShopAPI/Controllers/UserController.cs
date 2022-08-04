using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
