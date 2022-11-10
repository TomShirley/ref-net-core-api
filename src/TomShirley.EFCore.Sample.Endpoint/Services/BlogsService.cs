using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomShirley.EFCore.Sample.Database;
using TomShirley.EFCore.Sample.Endpoint.Models;

namespace TomShirley.EFCore.Sample.Endpoint.Services
{
    public class BlogsService : IBlogsService
    {
        private readonly IMapper _mapper;
        private readonly BlogsDbContext _dbContext;
        private readonly ILogger _logger;

        public BlogsService(IMapper mapper, BlogsDbContext dbcontext, ILogger logger)
        {
            _logger = logger;
            _dbContext = dbcontext;
            _mapper = mapper;
        }

        public async Task<Models.Blog> GetBlog(Guid id)
        {
            var blogEntity = await _dbContext.Blogs.Where(x => x.BlogId == id).FirstOrDefaultAsync();
            _logger.Debug("In GetBlog()");
            return _mapper.Map<Models.Blog>(blogEntity);
        }

        public async Task<IEnumerable<Models.Blog>> GetBlogs()
        {
            _logger.Debug("In GetBlogs()");
            var blogs = await _dbContext.Blogs
                                        .Include(blog => blog.Posts)
                                        .Include(blog => blog.Owner)
                                        .ToListAsync();
            return _mapper.Map<IEnumerable<Models.Blog>>(blogs);
        }
    }
}
