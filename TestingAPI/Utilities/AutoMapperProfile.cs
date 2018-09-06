using AutoMapper;
using TestingAPI.DTO;
using TestingAPI.Models;

namespace TestingAPI.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
