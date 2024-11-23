using AutoMapper;
using SignalRDto.ProductDto;
using SignalREntites.Entites;

namespace SignalRApi.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product,GetProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductWithCategory>()
                .ForMember(destinationMember : x=>x.CategoryName, memberOptions: p=>p.MapFrom(c=>c.Category.CategoryName))
                .ReverseMap();

        }
    }
}
