﻿// <auto-generated />
using MDS.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MDS.Migrations
{
    [DbContext(typeof(MdsDbContext))]
    partial class MdsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MDS.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MDS.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CrtDate");

                    b.Property<string>("Name");

                    b.Property<int>("RegionId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("MDS.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CrtDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Contries");
                });

            modelBuilder.Entity("MDS.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Content");

                    b.Property<string>("ContentType");

                    b.Property<int>("Height");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OrganizationId");

                    b.Property<string>("Prefix");

                    b.Property<int?>("ShareItemId");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("ShareItemId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MDS.Entities.NotificationTamplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ActivationDate");

                    b.Property<DateTime>("DiactivationDate");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<string>("Name");

                    b.Property<int>("Radius");

                    b.Property<string>("Text");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("NotificationTemplates");
                });

            modelBuilder.Entity("MDS.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("KeyWords");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("NewDate");

                    b.Property<string>("SiteUrl");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("MDS.Entities.OrganizationCategory", b =>
                {
                    b.Property<int>("Organization_Id");

                    b.Property<int>("Category_Id");

                    b.HasKey("Organization_Id", "Category_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("CategoryOrganizations");
                });

            modelBuilder.Entity("MDS.Entities.PhoneVerificationToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("Verified");

                    b.HasKey("Id");

                    b.ToTable("PhoneVerificationToken");
                });

            modelBuilder.Entity("MDS.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<DateTime?>("CrtDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("MDS.Entities.ShareItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Barcode");

                    b.Property<int?>("CountLimit");

                    b.Property<string>("CustomBarcode");

                    b.Property<string>("Description");

                    b.Property<string>("DetailsUrl");

                    b.Property<int>("DownloadCount");

                    b.Property<int?>("OrganizationId");

                    b.Property<string>("Percentage");

                    b.Property<DateTime?>("TimeLimit");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ShareItems");
                });

            modelBuilder.Entity("MDS.Entities.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<string>("Name");

                    b.Property<int?>("OrganizationId");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("Shedule");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("MDS.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CityId");

                    b.Property<int>("CouponsMaxCount");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<int>("DiscountCardsMaxCount");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool?>("Male");

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Points");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MDS.Entities.UserShare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ShareItemID");

                    b.Property<string>("UniqueCode");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("ShareItemID");

                    b.HasIndex("UserID");

                    b.ToTable("UserShare");
                });

            modelBuilder.Entity("MDS.Entities.City", b =>
                {
                    b.HasOne("MDS.Entities.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MDS.Entities.Image", b =>
                {
                    b.HasOne("MDS.Entities.Organization")
                        .WithMany("Images")
                        .HasForeignKey("OrganizationId");

                    b.HasOne("MDS.Entities.ShareItem")
                        .WithMany("Images")
                        .HasForeignKey("ShareItemId");
                });

            modelBuilder.Entity("MDS.Entities.OrganizationCategory", b =>
                {
                    b.HasOne("MDS.Entities.Category", "Category")
                        .WithMany("Organizations")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MDS.Entities.Organization", "Organization")
                        .WithMany("Categories")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MDS.Entities.Region", b =>
                {
                    b.HasOne("MDS.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MDS.Entities.ShareItem", b =>
                {
                    b.HasOne("MDS.Entities.Organization", "Organization")
                        .WithMany("ShareItems")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("MDS.Entities.Shop", b =>
                {
                    b.HasOne("MDS.Entities.Organization", "Organization")
                        .WithMany("Shops")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("MDS.Entities.User", b =>
                {
                    b.HasOne("MDS.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("MDS.Entities.UserShare", b =>
                {
                    b.HasOne("MDS.Entities.ShareItem", "ShareItem")
                        .WithMany("UserShare")
                        .HasForeignKey("ShareItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MDS.Entities.User", "User")
                        .WithMany("UserShare")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
