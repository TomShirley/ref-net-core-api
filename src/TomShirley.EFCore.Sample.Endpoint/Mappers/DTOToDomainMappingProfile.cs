using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace TomShirley.EFCore.Sample.Endpoint.Mappers
{
    public class DTOToDomainMappingProfile : Profile
    {
        public DTOToDomainMappingProfile()
        {
            CreateMap<Controllers.Blog, Models.Blog>();

            CreateMap<IEnumerable<Endpoint.Models.Blog>, Controllers.BlogsGetResponse>()
                .ForMember(x => x.Blogs, o => o.MapFrom(s => s));
        }
    }
}
