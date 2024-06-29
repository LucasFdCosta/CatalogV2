using AutoMapper;
using CatalogV2.Application.DTOs;
using CatalogV2.Domain.Entities;

namespace CatalogV2.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
