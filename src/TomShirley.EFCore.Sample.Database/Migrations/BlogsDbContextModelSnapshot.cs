﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TomShirley.EFCore.Sample.Database;

namespace TomShirley.EFCore.Sample.Database.Migrations
{
    [DbContext(typeof(BlogsDbContext))]
    partial class BlogsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TomShirley.EFCore.Sample.Database.Blog", b =>
                {
                    b.Property<Guid>("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OwnerUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.HasIndex("OwnerUserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("TomShirley.EFCore.Sample.Database.Post", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex(new[] { "BlogId" }, "IX_Posts_BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("TomShirley.EFCore.Sample.Database.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TomShirley.EFCore.Sample.Database.Blog", b =>
                {
                    b.HasOne("TomShirley.EFCore.Sample.Database.User", "Owner")
                        .WithMany("Blogs")
                        .HasForeignKey("OwnerUserId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("TomShirley.EFCore.Sample.Database.Post", b =>
                {
                    b.HasOne("TomShirley.EFCore.Sample.Database.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("TomShirley.EFCore.Sample.Database.Blog", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("TomShirley.EFCore.Sample.Database.User", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
