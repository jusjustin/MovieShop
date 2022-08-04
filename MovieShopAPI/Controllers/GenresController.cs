using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
