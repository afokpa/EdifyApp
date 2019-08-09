using AutoMapper;
using EdifyApp.API.Data;
using EdifyApp.API.Dtos;
using EdifyApp.API.Models;

namespace EdifyApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            // .ForMember(dest => dest.RemainingLeaveDays, opt => {
            //         opt.ResolveUsing(d => (d.RemainingLeaveDays - d.NumberOfDays));
            // });
            CreateMap<User, UserForIndividualDto>();
            // .ForMember(dest => dest.RemainingLeaveDays, opt => {
            //         opt.ResolveUsing(d => (d.RemainingLeaveDays - d.NumberOfDays));
            // });
            CreateMap<UserForUpdateDto, User>();
        }
    }
}