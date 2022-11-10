using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomShirley.EFCore.Sample.Endpoint.Models;
using AutoMapper;

namespace TomShirley.EFCore.Sample.Endpoint.Mappers
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Blog, Controllers.Blog>();

            CreateMap<Post, Controllers.Post>();

            CreateMap<User, Controllers.User>();
        }
    }
}
