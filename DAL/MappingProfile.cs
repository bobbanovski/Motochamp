using AutoMapper;
using WebApplicationBasic.Models;
using WebApplicationBasic.Dtos;

namespace WebApplicationBasic.DAL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Bike, BikeDto>();
            CreateMap<User, UserDto>();
        }
    }
}