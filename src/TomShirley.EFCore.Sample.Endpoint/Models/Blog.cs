using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomShirley.EFCore.Sample.Endpoint.Models
{
    public class Blog
    {
        public Guid Id { get; set; }

        public string Url { get; set; }

        public User Owner { get; set; }

        public IEnumerable<Post> Posts { get; set; }

    }
}
