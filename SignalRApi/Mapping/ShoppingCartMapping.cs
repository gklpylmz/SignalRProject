using AutoMapper;
using SignalRDto.ShoppingCartDto;
using SignalREntites.Entites;

namespace SignalRApi.Mapping
{
    public class ShoppingCartMapping : Profile
    {
        public ShoppingCartMapping()
        {
            CreateMap<ShoppingCart, ResultShoppingCartDto>().ReverseMap();
            CreateMap<ShoppingCart, CreateShoppingCartDto>().ReverseMap();
            CreateMap<ShoppingCart, UpdateShoppingCartDto>().ReverseMap();
            CreateMap<ShoppingCart, GetShoppingCartDto>().ReverseMap();
            CreateMap<ShoppingCart, ResultShoppingCartWithProductNameDto>()
                .ForMember(destinationMember: x => x.ProductName, memberOptions: p => p.MapFrom(c => c.Product.ProductName))
                .ReverseMap();
        }
    }
}
