using System;
using AutoMapper;
using ModernArchitectureShop.Basket.Domain;
using ModernArchitectureShop.Basket.Infrastructure.UseCases.AddItem;

namespace ModernArchitectureShop.Basket.Infrastructure.Dto
{
    public class ItemMappingProfile : Profile
    {
        public ItemMappingProfile()
        {
            CreateMap<Item, ItemDto>()
                .ForMember(dest => dest.ItemId, opt => opt.MapFrom(src => (Guid)src.ItemId));

            CreateMap<AddItemCommand, Item>()
                .ForMember(dest => dest.ItemId, arg => arg.MapFrom(src => (Guid)src.ItemId));
        }
    }
}
