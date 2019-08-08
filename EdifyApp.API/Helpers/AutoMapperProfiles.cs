using AutoMapper;
using EdifyApp.API.Dtos;
using EdifyApp.API.Models;

namespace EdifyApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForIndividualDto>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}