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
    [Migration("20231225120029_Global Id Column in Offer")]
    partial class GlobalIdColumninOffer
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

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            City = "Warsaw",
                            CountryId = 1,
                            FlatNumber = 10,
                            Street = "Nowowiejska",
                            StreetNumber = "17",
                            ZipCode = "12-345"
                        },
                        new
                        {
                            AddressId = 2,
                            City = "Krakow",
                            CountryId = 1,
                            Street = "Kwiatkowa",
                            StreetNumber = "5a",
                            ZipCode = "543-21"
                        },
                        new
                        {
                            AddressId = 3,
                            City = "Paris",
                            CountryId = 2,
                            FlatNumber = 3,
                            Street = "France street 1",
                            StreetNumber = "2",
                            ZipCode = "52006"
                        },
                        new
                        {
                            AddressId = 4,
                            City = "Lyon",
                            CountryId = 2,
                            Street = "France street 2",
                            StreetNumber = "5a",
                            ZipCode = "78264"
                        },
                        new
                        {
                            AddressId = 5,
                            City = "Berlin",
                            CountryId = 3,
                            FlatNumber = 3,
                            Street = "Germany street 1",
                            StreetNumber = "2",
                            ZipCode = "10117"
                        },
                        new
                        {
                            AddressId = 6,
                            City = "Madrid",
                            CountryId = 4,
                            Street = "Spain street 1",
                            StreetNumber = "3",
                            ZipCode = "28012"
                        });
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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("salt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "",
                            FirstName = "",
                            LastName = "",
                            Password = "",
                            Salt = new byte[0],
                            Username = ""
                        },
                        new
                        {
                            Id = 2,
                            Email = "mikwa@gmail.com",
                            FirstName = "Michal",
                            LastName = "Kwiatek",
                            Password = "B628F9FB03AD851FCDA3F3197695C8EEF0272320E076985C76BAC000AD92F2C551DC0FDBAD10C49FF19F20DC1223DFDD66119982761F5C62CB4C95E27F2E7C4D",
                            Salt = new byte[] { 98, 66, 90, 174, 74, 167, 146, 27, 212, 102, 191, 69, 78, 22, 154, 79, 240, 251, 77, 56, 210, 29, 42, 230, 51, 47, 127, 184, 168, 155, 31, 65, 216, 31, 247, 43, 14, 142, 40, 122, 252, 220, 86, 48, 173, 210, 186, 47, 88, 72, 43, 253, 38, 6, 169, 5, 16, 202, 98, 44, 247, 167, 205, 32 },
                            Username = "mikwa"
                        },
                        new
                        {
                            Id = 3,
                            Email = "kakow@gmail.com",
                            FirstName = "Kacper",
                            LastName = "Kowalski",
                            Password = "479FD73EA58D61BF6FC2921F542492F8FB7154FE0071BA3FA35B37CBE02F62F0D8EFF98FA4378EB2FAF1D33F8B13BF60D0F7EE4B0C01B4A29E65132FC736759C",
                            Salt = new byte[] { 134, 46, 11, 41, 131, 209, 160, 237, 158, 46, 225, 130, 178, 134, 135, 3, 134, 164, 180, 34, 218, 212, 152, 107, 187, 180, 94, 20, 254, 236, 131, 245, 161, 241, 193, 172, 46, 216, 172, 246, 206, 158, 168, 92, 199, 148, 1, 38, 251, 86, 180, 67, 180, 156, 190, 138, 125, 143, 165, 243, 224, 87, 92, 7 },
                            Username = "kakow"
                        },
                        new
                        {
                            Id = 4,
                            Email = "mateuszlipek@gmail.com",
                            FirstName = "Mateusz",
                            LastName = "Lipek",
                            Password = "4C191C8DA203AEFAC7A31F6FD11AA19CFC5C0373CD7CEBF706B25344334B6F6AA69A6D443A48961C293F800B2B5699C916D65ECF18C58663199D66ED76B0F051",
                            Salt = new byte[] { 36, 195, 81, 234, 213, 26, 175, 12, 157, 75, 24, 238, 176, 143, 154, 61, 2, 73, 184, 0, 238, 100, 156, 254, 7, 163, 49, 229, 254, 140, 216, 127, 149, 217, 223, 85, 162, 234, 215, 103, 163, 28, 57, 62, 245, 167, 41, 137, 63, 181, 71, 31, 8, 18, 0, 254, 71, 15, 144, 74, 238, 49, 198, 66 },
                            Username = "lipek"
                        });
                });

            modelBuilder.Entity("mini_package_api.Models.ClientAddress", b =>
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

                    b.ToTable("ClientAddresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            ClientId = 2,
                            IsDefault = true
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            ClientId = 2,
                            IsDefault = false
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            ClientId = 2,
                            IsDefault = false
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 4,
                            ClientId = 3,
                            IsDefault = true
                        },
                        new
                        {
                            Id = 5,
                            AddressId = 5,
                            ClientId = 3,
                            IsDefault = false
                        },
                        new
                        {
                            Id = 6,
                            AddressId = 6,
                            ClientId = 3,
                            IsDefault = false
                        });
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

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryCode = "PL",
                            CountryName = "Poland"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryCode = "FR",
                            CountryName = "France"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryCode = "DE",
                            CountryName = "Germany"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryCode = "ES",
                            CountryName = "Spain"
                        });
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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("role");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("salt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "janow@gmail.com",
                            FirstName = "Jan",
                            LastName = "Nowak",
                            Password = "9AA388827DEE80EE9CE1A69C1673649E1F4CB0C2D5DBBD45E952877AB9D9DE77DCA2469C3D97A7CDA31A8E2A80DB0640DDEB53B257A3ADFAF14A3EBEE85DDBAE",
                            Role = "OfficeWorker",
                            Salt = new byte[] { 70, 142, 200, 91, 21, 42, 30, 224, 250, 111, 23, 151, 216, 255, 132, 9, 160, 236, 39, 200, 125, 245, 52, 197, 37, 132, 104, 158, 169, 37, 235, 99, 36, 31, 118, 224, 105, 68, 101, 226, 47, 231, 104, 218, 130, 103, 0, 4, 214, 51, 95, 161, 11, 198, 105, 28, 184, 147, 215, 245, 104, 37, 237, 167 },
                            Username = "janow"
                        },
                        new
                        {
                            Id = 2,
                            Email = "frwys@gmail.com",
                            FirstName = "Franek",
                            LastName = "Wyszomierski",
                            Password = "E3551CB2A3C08E93415231FA52D6948D92F4984343ECBFD2045C77544534A74F168FE7A48A2D63E0368ED22750CF7B0D2B75C3502A069A2E1463EFAC89628F05",
                            Role = "Courier",
                            Salt = new byte[] { 68, 17, 91, 125, 160, 111, 147, 91, 30, 30, 194, 69, 210, 14, 207, 79, 198, 31, 16, 206, 205, 117, 98, 125, 128, 0, 58, 32, 112, 66, 66, 111, 233, 226, 48, 170, 238, 104, 45, 106, 225, 171, 163, 63, 240, 78, 94, 185, 254, 106, 53, 227, 151, 153, 227, 163, 146, 144, 107, 98, 106, 222, 218, 247 },
                            Username = "frwys"
                        },
                        new
                        {
                            Id = 3,
                            Email = "igzal@gmail.com",
                            FirstName = "Ignacy",
                            LastName = "Zalewski",
                            Password = "16B99EF331A390CBCF7B40506963010A87B69C6FB269044CDCDD8F344D9EFE86B4D50D286BE01D653C14A0AD7BA11B300DE726CE3053AFE725C9387D41FB415C",
                            Role = "Courier",
                            Salt = new byte[] { 38, 205, 78, 135, 135, 59, 144, 76, 54, 215, 138, 213, 194, 152, 51, 85, 165, 215, 173, 227, 68, 228, 182, 229, 91, 30, 54, 144, 135, 181, 254, 226, 12, 12, 254, 120, 153, 37, 78, 73, 54, 253, 209, 135, 183, 171, 64, 36, 169, 50, 168, 155, 15, 136, 192, 39, 148, 186, 210, 214, 13, 187, 72, 212 },
                            Username = "igzal"
                        });
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

                    b.Property<int>("DestinationClientAddressId")
                        .HasColumnType("int")
                        .HasColumnName("destination_client_address_id");

                    b.Property<bool>("IsIncoming")
                        .HasColumnType("bit")
                        .HasColumnName("is_incoming");

                    b.Property<decimal>("PackageSizeHeight")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_height");

                    b.Property<decimal>("PackageSizeLength")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_length");

                    b.Property<decimal>("PackageSizeWidth")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("package_size_width");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("pickup_date");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("priority");

                    b.Property<int>("SourceClientAddressId")
                        .HasColumnType("int")
                        .HasColumnName("source_client_address_id");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(6,3)")
                        .HasColumnName("weight");

                    b.HasKey("InquireId");

                    b.HasIndex("DestinationClientAddressId");

                    b.HasIndex("SourceClientAddressId");

                    b.ToTable("Inquires");

                    b.HasData(
                        new
                        {
                            InquireId = 1,
                            CreatedDate = new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryAtWeekend = false,
                            DeliveryDate = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationClientAddressId = 1,
                            IsIncoming = false,
                            PackageSizeHeight = 7.75m,
                            PackageSizeLength = 3m,
                            PackageSizeWidth = 10.5m,
                            PickupDate = new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = "Low",
                            SourceClientAddressId = 2,
                            Weight = 1m
                        },
                        new
                        {
                            InquireId = 2,
                            CreatedDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryAtWeekend = true,
                            DeliveryDate = new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationClientAddressId = 1,
                            IsIncoming = false,
                            PackageSizeHeight = 5.25m,
                            PackageSizeLength = 2m,
                            PackageSizeWidth = 2.5m,
                            PickupDate = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = "High",
                            SourceClientAddressId = 3,
                            Weight = 2m
                        },
                        new
                        {
                            InquireId = 3,
                            CreatedDate = new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryAtWeekend = false,
                            DeliveryDate = new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationClientAddressId = 4,
                            IsIncoming = false,
                            PackageSizeHeight = 6.30m,
                            PackageSizeLength = 3.6m,
                            PackageSizeWidth = 12.35m,
                            PickupDate = new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = "Low",
                            SourceClientAddressId = 5,
                            Weight = 0.75m
                        },
                        new
                        {
                            InquireId = 4,
                            CreatedDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeliveryAtWeekend = true,
                            DeliveryDate = new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DestinationClientAddressId = 4,
                            IsIncoming = false,
                            PackageSizeHeight = 4m,
                            PackageSizeLength = 1.5m,
                            PackageSizeWidth = 3m,
                            PickupDate = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Priority = "High",
                            SourceClientAddressId = 6,
                            Weight = 12m
                        });
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

                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("global_id")
                        .HasDefaultValueSql("NEWID()");

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

                    b.HasData(
                        new
                        {
                            OfferId = 1,
                            CourierId = 2,
                            Guid = new Guid("15114657-f81e-4df0-9f0b-a9d285ea120f"),
                            InquireId = 1,
                            OfferStatus = "AtWarehouse",
                            Price = 100m,
                            TeamName = "MiNIPackage"
                        },
                        new
                        {
                            OfferId = 2,
                            CourierId = 3,
                            Guid = new Guid("0e8820db-21b3-4999-b4eb-553aeccbe505"),
                            InquireId = 4,
                            OfferStatus = "OfferStatusEnum",
                            Price = 70.28m,
                            TeamName = "MiNIPackage"
                        });
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

            modelBuilder.Entity("mini_package_api.Models.ClientAddress", b =>
                {
                    b.HasOne("mini_package_api.Models.Address", "Address")
                        .WithMany("ClientAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mini_package_api.Models.Client", "Client")
                        .WithMany("ClientAddresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("mini_package_api.Models.Inquire", b =>
                {
                    b.HasOne("mini_package_api.Models.ClientAddress", "DestinationClientAddress")
                        .WithMany("DestinationInquires")
                        .HasForeignKey("DestinationClientAddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("mini_package_api.Models.ClientAddress", "SourceClientAddress")
                        .WithMany("SourceInquires")
                        .HasForeignKey("SourceClientAddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DestinationClientAddress");

                    b.Navigation("SourceClientAddress");
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

            modelBuilder.Entity("mini_package_api.Models.Address", b =>
                {
                    b.Navigation("ClientAddresses");
                });

            modelBuilder.Entity("mini_package_api.Models.Client", b =>
                {
                    b.Navigation("ClientAddresses");
                });

            modelBuilder.Entity("mini_package_api.Models.ClientAddress", b =>
                {
                    b.Navigation("DestinationInquires");

                    b.Navigation("SourceInquires");
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
#pragma warning restore 612, 618
        }
    }
}
