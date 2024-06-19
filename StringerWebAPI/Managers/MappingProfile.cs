using AutoMapper;
using StringerWebAPI.DataTransferObjects;
using StringerWebAPI.Models;

namespace StringerWebAPI.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
