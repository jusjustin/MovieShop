using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieShopDbContext _movieShopDbContext;

        public MovieRepository(MovieShopDbContext movieShopDbContext)
        {
            _movieShopDbContext = movieShopDbContext;
        }

        public Movie GetById(int id)
        {
            var movieDetails = _movieShopDbContext.Movies
                .Include(m => m.GenresOfMovie).ThenInclude(m => m.Genre)
                .Include(m => m.CastsOfMovie).ThenInclude(m => m.Cast)
                .Include(m => m.Trailers)
                .FirstOrDefault(m => m.Id == id);
            return movieDetails;
        }

        public List<Movie> GetTop30HighestRevenueMovies()
        {
            //LINQ
            var movies = _movieShopDbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToList();

            return movies;
        }

        public List<Movie> GetTop30RatedMovies()
        {
            throw new NotImplementedException();
        }
    }
}
