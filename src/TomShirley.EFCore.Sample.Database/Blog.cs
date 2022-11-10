using System;
using System.Collections.Generic;

#nullable disable

namespace TomShirley.EFCore.Sample.Database
{
    public partial class Blog
    {
        public Blog()
        {
            Posts = new HashSet<Post>();
        }

        public Guid BlogId { get; set; }
        public string Url { get; set; }

        public virtual User Owner { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
