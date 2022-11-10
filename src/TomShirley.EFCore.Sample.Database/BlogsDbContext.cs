using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TomShirley.EFCore.Sample.Database
{
    public partial class BlogsDbContext : DbContext
    {
        public BlogsDbContext()
        {
        }

        public BlogsDbContext(DbContextOptions<BlogsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.BlogId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => e.BlogId, "IX_Posts_BlogId");

                entity.Property(e => e.PostId).ValueGeneratedNever();

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.BlogId);
            });

            OnModelCreatingPartial(modelBuilder);   
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
