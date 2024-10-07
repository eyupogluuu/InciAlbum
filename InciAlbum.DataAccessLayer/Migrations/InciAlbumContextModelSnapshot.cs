﻿// <auto-generated />
using System;
using InciAlbum.DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InciAlbum.DataAccessLayer.Migrations
{
    [DbContext(typeof(InciAlbumContext))]
    partial class InciAlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("aboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("aboutId"), 1L, 1);

                    b.Property<string>("descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("aboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("adminId"), 1L, 1);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("adminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("contactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("contactId"), 1L, 1);

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.Image", b =>
                {
                    b.Property<int>("imageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("imageId"), 1L, 1);

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("imageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.myAdress", b =>
                {
                    b.Property<int>("myAdressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("myAdressId"), 1L, 1);

                    b.Property<string>("descreption1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descreption2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descreption3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("map")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("myAdressId");

                    b.ToTable("myAdresses");
                });

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.myService", b =>
                {
                    b.Property<int>("myServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("myServiceId"), 1L, 1);

                    b.Property<string>("descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("myServiceId");

                    b.ToTable("myServices");
                });

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.Notice", b =>
                {
                    b.Property<int>("noticeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("noticeId"), 1L, 1);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<string>("tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("noticeId");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productId"), 1L, 1);

                    b.Property<string>("descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InciAlbum.EntityLayer.Concrete.Stuff", b =>
                {
                    b.Property<int>("stuffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("stuffId"), 1L, 1);

                    b.Property<string>("faceUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("twUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("websiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("stuffId");

                    b.ToTable("Stuffs");
                });
#pragma warning restore 612, 618
        }
    }
}
