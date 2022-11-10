using System;
using System.Collections.Generic;

#nullable disable

namespace TomShirley.EFCore.Sample.Database
{
    public partial class Post
    {
        public Guid PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
