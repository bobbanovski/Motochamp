using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationBasic.DAL;
using AutoMapper;
using WebApplicationBasic.Models;
using WebApplicationBasic.Dtos;

namespace WebApplicationBasic.Controllers
{
    public class BikesController
    {
        private MotoDbContext _context;
        private IMapper _mapper;

        public BikesController(MotoDbContext context, IMapper mapper){
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGetAttribute("/api/bikes")]
        public IEnumerable<BikeDto> GetBikes() {
            var bikes = _context.Bikes.ToList();
            return _mapper.Map<List<Bike>, List<BikeDto>>(bikes);
        }
    }
}