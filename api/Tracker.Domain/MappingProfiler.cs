using AutoMapper;
using Tracker.Data.Entities;
using Tracker.Domain.DTOs;

namespace Tracker.Domain
{
    public class MappingProfiler : Profile
    {
        public MappingProfiler()
        {
            CreateMap<User, UserDto>();
            CreateMap<Category, CategoryDto>();
        }   
    }
}