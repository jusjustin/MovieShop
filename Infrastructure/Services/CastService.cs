using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServicesContacts;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {

        Task<MovieDetailsModel> ICastService.GetCastDetails(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
