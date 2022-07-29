using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServicesContacts;
using Infrastructure.Data;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;
        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }

        public async Task<CastDetailsModel> GetCastDetails(int castId)
        {
            var castDetails = await _castRepository.GetById(castId);

            var castDetailsModel = new CastDetailsModel
            {
                Id = castDetails.Id,
                Name = castDetails.Name,
                Gender = castDetails.Gender,
                ProfilePath = castDetails.ProfilePath
            };

            foreach(var moviesofcast in castDetails.MoviesOfCast)
            {
                castDetailsModel.Movies.Add(new MovieCharacterCardModel { Id = moviesofcast.Movie.Id, Title = moviesofcast.Movie.Title, PosterUrl = moviesofcast.Movie.PosterUrl, Character = moviesofcast.Character});
            }

            return castDetailsModel;
        }

    }
}
