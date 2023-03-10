// <auto-generated />
using System;
using DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30");

            modelBuilder.Entity("DataAccess.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entity.Concrete.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AboutMapLocation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("Entity.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogContent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BlogCreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogImage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("BlogStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogThumbnailImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BlogId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Entity.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entity.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentContent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentUserId")
                        .HasColumnType("TEXT");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Entity.Concrete.Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("WriterAbout")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterName")
                        .HasColumnType("TEXT");

                    b.Property<string>("WriterPassword")
                        .HasColumnType("TEXT");

                    b.Property<bool>("WriterStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("WriterId");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("Entity.Concrete.Blog", b =>
                {
                    b.HasOne("Entity.Concrete.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Concrete.Comment", b =>
                {
                    b.HasOne("Entity.Concrete.Blog", "Blog")
                        .WithMany("Comment")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
