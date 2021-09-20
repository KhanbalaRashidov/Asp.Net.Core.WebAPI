using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace CompanyEmployees.API.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress,
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
        }
    }
}
