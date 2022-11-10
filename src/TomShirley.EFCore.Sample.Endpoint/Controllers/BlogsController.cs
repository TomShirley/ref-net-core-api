using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomShirley.EFCore.Sample.Endpoint.Services;
using Microsoft.EntityFrameworkCore;
using TomShirley.EFCore.Sample.Database;
using AutoMapper;

namespace TomShirley.EFCore.Sample.Endpoint.Controllers
{
    public class BlogsControllerImpl : IBlogsController
    {
        private readonly IBlogsService _blogsService;
        private readonly IMapper _mapper;


        public BlogsControllerImpl(IBlogsService blogsService,
                                IMapper mapper)
        {
            _blogsService = blogsService;
            _mapper = mapper;
        }

        public async Task<Blog> GetBlogAsync(HttpContext context, Guid id)
        {
            return _mapper.Map<Controllers.Blog>(await _blogsService.GetBlog(id));
        }

        public async Task<BlogsGetResponse> GetBlogsAsync(HttpContext context)
        {
            return _mapper.Map<BlogsGetResponse>(await _blogsService.GetBlogs());
        }
    }
}
