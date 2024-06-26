﻿// <auto-generated />
using System;
using ECommerce.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240421210743_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("ECommerce.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 851, DateTimeKind.Local).AddTicks(1161),
                            Name = "Games",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 851, DateTimeKind.Local).AddTicks(1176),
                            Name = "Kids",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 851, DateTimeKind.Local).AddTicks(1284),
                            Name = "Books, Tools & Baby",
                            isDeleted = true
                        });
                });

            modelBuilder.Entity("ECommerce.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 852, DateTimeKind.Local).AddTicks(3570),
                            Name = "Elektrik",
                            ParentId = 0,
                            Priorty = 1,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 852, DateTimeKind.Local).AddTicks(3586),
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 852, DateTimeKind.Local).AddTicks(3589),
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 852, DateTimeKind.Local).AddTicks(3592),
                            Name = "Kadın",
                            ParentId = 2,
                            Priorty = 1,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("ECommerce.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 857, DateTimeKind.Local).AddTicks(3925),
                            Description = "Magni rem consequatur voluptas veritatis.",
                            Title = "İure.",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 857, DateTimeKind.Local).AddTicks(3992),
                            Description = "Aut çorba sevindi ad yaptı.",
                            Title = "Quae orta.",
                            isDeleted = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 857, DateTimeKind.Local).AddTicks(4048),
                            Description = "Yapacakmış modi düşünüyor hesap sokaklarda.",
                            Title = "Ona yaptı.",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("ECommerce.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 861, DateTimeKind.Local).AddTicks(6578),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Discount = 6.148261411880170m,
                            Price = 19.21m,
                            Title = "Refined Steel Salad",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 4, 22, 0, 7, 42, 861, DateTimeKind.Local).AddTicks(6635),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Discount = 0.3878697632974850m,
                            Price = 346.88m,
                            Title = "Sleek Plastic Salad",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("ECommerce.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce.Domain.Entities.Detail", b =>
                {
                    b.HasOne("ECommerce.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECommerce.Domain.Entities.Product", b =>
                {
                    b.HasOne("ECommerce.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("ECommerce.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
