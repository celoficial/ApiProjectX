﻿// <auto-generated />
using System;
using ApiProjectX.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiProjectX.Infra.Data.Migrations
{
    [DbContext(typeof(ProjectXContext))]
    partial class ProjectXContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeAuthorEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("AuthorId");

                    b.ToTable("AnimeAuthor");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeCategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("AnimeCategory");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Rating")
                        .HasMaxLength(5)
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Anime");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AuthorEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.CategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.StudioEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudioName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeAuthorEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.AnimeEntity", "Anime")
                        .WithMany("AnimeAuthor")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ApiProjectX.Domain.Entities.AuthorEntity", "Author")
                        .WithMany("AnimeAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Anime");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeCategoryEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.AnimeEntity", "Anime")
                        .WithMany("AnimeCategory")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ApiProjectX.Domain.Entities.CategoryEntity", "Category")
                        .WithMany("AnimeCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Anime");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeEntity", b =>
                {
                    b.Navigation("AnimeAuthor");

                    b.Navigation("AnimeCategory");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AuthorEntity", b =>
                {
                    b.Navigation("AnimeAuthor");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.CategoryEntity", b =>
                {
                    b.Navigation("AnimeCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
