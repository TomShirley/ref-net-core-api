using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomShirley.EFCore.Sample.Endpoint.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Blog Blog { get; set; }
    }
}
