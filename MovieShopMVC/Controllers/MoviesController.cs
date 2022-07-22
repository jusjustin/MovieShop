using ApplicationCore.ServicesContacts;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var movieDetails = _movieService.GetMovieDetails(id);
            return View(movieDetails);
        }
    }
}
