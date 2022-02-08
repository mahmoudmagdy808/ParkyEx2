using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkyEx2.Models.Dtos;
using ParkyEx2.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyEx2.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
    public class NationalParksController : Controller
    {
        private readonly IMapper _mapper;
        private INationalParkRepository _npRepo;

        public NationalParksController(INationalParkRepository npRepo, IMapper mapper)
        {
            _mapper = mapper;
            _npRepo = npRepo;

        }

        [HttpGet]
        public IActionResult GetNationalParks()
        {
            //var ObjList = _npRepo.GetNationalParks();
            var ObjDto = new List<NationalParkDto>();
            //foreach (var obj in ObjList)
            //{
            //   // ObjDto.Add(_mapper.Map<NationalParkDto>(obj));
            //}
            return Ok();
        }

    }
}
