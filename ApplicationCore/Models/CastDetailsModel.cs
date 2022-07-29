﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class CastDetailsModel
    {
        public CastDetailsModel()
        {
            Movies = new List<MovieCharacterCardModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ProfilePath { get; set; }

        public List<MovieCharacterCardModel> Movies { get; set; }
    }
}
