using AutoMapper;
using ParkyEx2.Models;
using ParkyEx2.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyEx2.ParkyMapper
{
    public class ParkyMapping:Profile
    {
        public ParkyMapping()
        {
            CreateMap<NationalPark, NationalParkDto>().ReverseMap();
        }
    }
}
