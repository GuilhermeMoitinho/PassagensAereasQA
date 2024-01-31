using AutoMapper;
using BackEndAeroQA.Application.Mapper.Mappings;
using BackEndAeroQA.Domain.Entity;

namespace BackEndAeroQA.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Passageiro, PassageiroDto>().ReverseMap();
            CreateMap<Voo, VooDto>().ReverseMap();
        }
    }
}
