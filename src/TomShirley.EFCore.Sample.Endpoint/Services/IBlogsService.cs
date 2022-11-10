using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TomShirley.EFCore.Sample.Endpoint.Models;

namespace TomShirley.EFCore.Sample.Endpoint.Services
{
    public interface IBlogsService
    {
        Task<Blog> GetBlog(Guid id);

        Task<IEnumerable<Blog>> GetBlogs();
    }
}