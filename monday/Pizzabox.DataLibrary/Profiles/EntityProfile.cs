using AutoMapper;
using Pizzabox.AppLibrary.Abstracts;
using Pizzabox.AppLibrary.Models;
using Pizzabox.DataLibrary.Entities;

namespace Pizzabox.DataLibrary.Mappers
{
  public class EntityProfile : Profile
  {
    public EntityProfile()
    {
      CreateMap<ABaseEntity, CrustModel>();
      CreateMap<ABaseEntity, AUserModel>();
      CreateMap<ABaseEntity, AUserModel>();
      CreateMap<ABaseEntity, OrderModel>();
      CreateMap<ABaseEntity, APizzaModel>();
      CreateMap<ABaseEntity, SizeModel>();
      CreateMap<ABaseEntity, AStoreModel>();
    }
  }
}
