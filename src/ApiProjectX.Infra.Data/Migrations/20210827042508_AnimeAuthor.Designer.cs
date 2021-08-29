﻿// <auto-generated />
using System;
using ApiProjectX.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiProjectX.Infra.Data.Migrations
{
    [DbContext(typeof(ProjectXContext))]
    [Migration("20210827042508_AnimeAuthor")]
    partial class AnimeAuthor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AcessTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AcessType");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeAuthorEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AuthorId")
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

                    b.Property<Guid?>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
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

                    b.Property<string>("Tags")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

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

            modelBuilder.Entity("ApiProjectX.Domain.Entities.EpisodeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionEpisode")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EpisodeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgEpisodeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SeasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("Episode");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.SeasonEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.StudioAnimeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StudioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("StudioId");

                    b.ToTable("StudioAnimeEntity");
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

            modelBuilder.Entity("ApiProjectX.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AcessTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserBirth")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserNick")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("AcessTypeId");

                    b.HasIndex("UserEmail")
                        .IsUnique();

                    b.HasIndex("UserNick")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.WatchEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WatchControl")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("UserId");

                    b.ToTable("Watch");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeAuthorEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.AnimeEntity", "Anime")
                        .WithMany("AnimeAuthor")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("ApiProjectX.Domain.Entities.AuthorEntity", "Author")
                        .WithMany("AnimeAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Anime");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.AnimeCategoryEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.AnimeEntity", "Anime")
                        .WithMany("AnimeCategory")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("ApiProjectX.Domain.Entities.CategoryEntity", "Category")
                        .WithMany("AnimeCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Anime");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.EpisodeEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.SeasonEntity", "Season")
                        .WithMany("Episode")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Season");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.SeasonEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.AnimeEntity", "Anime")
                        .WithMany()
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Anime");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.StudioAnimeEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.AnimeEntity", "Anime")
                        .WithMany()
                        .HasForeignKey("AnimeId");

                    b.HasOne("ApiProjectX.Domain.Entities.StudioEntity", "Studio")
                        .WithMany()
                        .HasForeignKey("StudioId");

                    b.Navigation("Anime");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.UserEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.AcessTypeEntity", "AcessType")
                        .WithMany()
                        .HasForeignKey("AcessTypeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("AcessType");
                });

            modelBuilder.Entity("ApiProjectX.Domain.Entities.WatchEntity", b =>
                {
                    b.HasOne("ApiProjectX.Domain.Entities.AnimeEntity", "Anime")
                        .WithMany()
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("ApiProjectX.Domain.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Anime");

                    b.Navigation("User");
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

            modelBuilder.Entity("ApiProjectX.Domain.Entities.SeasonEntity", b =>
                {
                    b.Navigation("Episode");
                });
#pragma warning restore 612, 618
        }
    }
}