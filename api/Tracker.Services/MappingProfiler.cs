using AutoMapper;
using Tracker.Data.Entities;
using Tracker.Services.DTOs;

namespace Tracker.Services
{
    public class MappingProfiler : Profile
    {
        public MappingProfiler() 
        {
            CreateMap<User, UserDto>().ReverseMap();
        }   
    }
}