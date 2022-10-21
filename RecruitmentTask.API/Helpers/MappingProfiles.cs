using AutoMapper;
using RecruitmentTask.Core.Dtos;
using RecruitmentTask.Core.Entities;

namespace RecruitmentTask.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductResultDto>();
        }
    }
}
