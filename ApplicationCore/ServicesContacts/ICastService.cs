﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServicesContacts
{
    public interface ICastService
    {
        //Task<List<MovieCardModel>> GetMoviesFromCast();
        Task<CastDetailsModel> GetCastDetails(int castId);
    }
}
