using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
