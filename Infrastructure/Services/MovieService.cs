using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServicesContacts;
using Infrastructure.Repositories___Implements_Contract;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public List<MovieCardModel> GetTopRevenueMovies()
        {
            var movieRepository = new MovieRepository();
            var movies = movieRepository.GetTop30HighestRevenueMovies();

            var movieCards = new List<MovieCardModel>();
            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardModel { Id = movie.Id, Title = movie.Title, PosterUrl = movie.PosterURL });
            }
            return movieCards;
        }
    }
}
