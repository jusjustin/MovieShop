using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    public class CastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
