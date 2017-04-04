using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationBasic.DAL;
using AutoMapper;
using WebApplicationBasic.Models;
using WebApplicationBasic.Dtos;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationBasic.Controllers
{
    public class BikesController : Controller
    {
        private readonly MotoDbContext _context;
        private readonly IMapper _mapper;

        public BikesController(MotoDbContext context, IMapper mapper){
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet("/api/bikes")]
        public async Task<IEnumerable<Bike>> GetBikes() {
            
            return await _context.Bikes.Include(m => m.Models).ToListAsync();
        }
    }
}