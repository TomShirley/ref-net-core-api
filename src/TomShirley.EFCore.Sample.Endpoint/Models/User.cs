using System;
using System.Collections.Generic;

#nullable disable

namespace TomShirley.EFCore.Sample.Endpoint.Models
{
    public partial class User
    {
        public User()
        {
            Blogs = new HashSet<Blog>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
