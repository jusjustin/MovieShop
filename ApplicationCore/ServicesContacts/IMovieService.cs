using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServicesContacts
{
    public interface IMovieService
    {
        Task<List<MovieCardModel>> GetTopRevenueMovies();
        Task<MovieDetailsModel> GetMovieDetails(int movieId);
    }
}
