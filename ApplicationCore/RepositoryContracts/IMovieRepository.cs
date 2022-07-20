using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryContracts
{
    public interface IMovieRepository
    {
        List<Movie> GetTop30HighestRevenueMovies();
        List<Movie> GetTop30RatedMovies();
        Movie GetById(int id);
    }
}
