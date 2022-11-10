using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomShirley.EFCore.Sample.Endpoint.Models;
using AutoMapper;

namespace TomShirley.EFCore.Sample.Endpoint.Mappers
{
    public class EntityToDomainMappingProfile : Profile
    {
        public EntityToDomainMappingProfile()
        {
            CreateMap<Database.Blog, Models.Blog>()
                .ForMember(x => x.Id, opt => opt.MapFrom(s => s.BlogId));

            CreateMap<Database.User, Models.User>()
                .ForMember(x => x.Id, opt => opt.MapFrom(s => s.UserId));

            CreateMap<Database.Post, Models.Post>()
                .ForMember(x => x.Id, opt => opt.MapFrom(s => s.PostId));
        }
    }
}
