﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mini_package_api.DbContexts;

#nullable disable

namespace mini_package_api.Migrations
{
    [DbContext(typeof(MiniPackageDbContext))]
    [Migration("20231031150139_User table split")]
    partial class Usertablesplit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("mini_package_api.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city");

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.Property<int?>("FlatNumber")
                        .HasColumnType("int")
                        .HasColumnName("flat_number");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("street");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("street_number");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("zip_code");

                    b.HasKey("AddressId");

                    b.HasIndex("CountryId");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("mini_package_api.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("client_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("mini_package_api.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country_code");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("country_name");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("mini_package_api.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("mini_package_api.Models.Inquire", b =>
                {
                    b.Property<int>("InquireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("inquire_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InquireId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_date");

                    b.Property<bool>("DeliveryAtWeekend")
                        .HasColumnType("bit")
                        .HasColumnName("delivery_at_weekend");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("delivery_date");

                    b.Property<int>("DestinationAddressId")
                        .HasColumnType("int")
                        .HasColumnName("destination_address_id");

                    b.Property<bool>("IsIncoming")
                        .HasColumnType("bit")
                        .HasColumnName("is_incoming");

                    b.Property<decimal>("PackageSizeX")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_x");

                    b.Property<decimal>("PackageSizeY")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_y");

                    b.Property<decimal>("PackageSizeZ")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_z");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("pickup_date");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("priority");

                    b.Property<int>("SourceAddressId")
                        .HasColumnType("int")
                        .HasColumnName("source_address_id");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(6,3)")
                        .HasColumnName("weight");

                    b.HasKey("InquireId");

                    b.HasIndex("DestinationAddressId");

                    b.HasIndex("SourceAddressId");

                    b.ToTable("Inquires");
                });

            modelBuilder.Entity("mini_package_api.Models.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("offer_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfferId"));

                    b.Property<int>("CourierId")
                        .HasColumnType("int")
                        .HasColumnName("courier_id");

                    b.Property<int>("InquireId")
                        .HasColumnType("int")
                        .HasColumnName("inquire_id");

                    b.Property<string>("OfferStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("offer_status");

                    b.Property<decimal>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("team_name");

                    b.HasKey("OfferId");

                    b.HasIndex("CourierId");

                    b.HasIndex("InquireId")
                        .IsUnique();

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("mini_package_api.Models.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("client_id");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit")
                        .HasColumnName("is_default");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ClientId");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("mini_package_api.Models.Address", b =>
                {
                    b.HasOne("mini_package_api.Models.Country", "Country")
                        .WithMany("Addresses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("mini_package_api.Models.Inquire", b =>
                {
                    b.HasOne("mini_package_api.Models.UserAddress", "DestinationUserAddress")
                        .WithMany("DestinationInquires")
                        .HasForeignKey("DestinationAddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("mini_package_api.Models.UserAddress", "SourceUserAddress")
                        .WithMany("SourceInquires")
                        .HasForeignKey("SourceAddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DestinationUserAddress");

                    b.Navigation("SourceUserAddress");
                });

            modelBuilder.Entity("mini_package_api.Models.Offer", b =>
                {
                    b.HasOne("mini_package_api.Models.Employee", "Courier")
                        .WithMany("Offers")
                        .HasForeignKey("CourierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mini_package_api.Models.Inquire", "Inquire")
                        .WithOne("Offer")
                        .HasForeignKey("mini_package_api.Models.Offer", "InquireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courier");

                    b.Navigation("Inquire");
                });

            modelBuilder.Entity("mini_package_api.Models.UserAddress", b =>
                {
                    b.HasOne("mini_package_api.Models.Address", "Address")
                        .WithMany("UserAddress")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mini_package_api.Models.Client", "Client")
                        .WithMany("UserAddress")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("mini_package_api.Models.Address", b =>
                {
                    b.Navigation("UserAddress");
                });

            modelBuilder.Entity("mini_package_api.Models.Client", b =>
                {
                    b.Navigation("UserAddress");
                });

            modelBuilder.Entity("mini_package_api.Models.Country", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("mini_package_api.Models.Employee", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("mini_package_api.Models.Inquire", b =>
                {
                    b.Navigation("Offer")
                        .IsRequired();
                });

            modelBuilder.Entity("mini_package_api.Models.UserAddress", b =>
                {
                    b.Navigation("DestinationInquires");

                    b.Navigation("SourceInquires");
                });
#pragma warning restore 612, 618
        }
    }
}
