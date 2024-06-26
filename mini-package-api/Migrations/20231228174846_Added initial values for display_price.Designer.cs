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
    [Migration("20231228174846_Added initial values for display_price")]
    partial class Addedinitialvaluesfordisplay_price
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

                    b.Property<bool>("Newsletter")
                        .HasColumnType("bit")
                        .HasColumnName("newsletter");

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
                            Newsletter = false,
                            Password = "",
                            Salt = new byte[0],
                            Username = "guest"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mikwa@gmail.com",
                            FirstName = "Michal",
                            LastName = "Kwiatek",
                            Newsletter = false,
                            Password = "E1839E681B3BC0DB3AD6A1318DC210CF7230EAE4E46E741507C5AEBAA7C10D3B8073EC6CFB5200CE6EAC00EF128A78D2C5A8EBBE2710A02F6E39E9BB8F6C3689",
                            Salt = new byte[] { 113, 158, 127, 29, 163, 239, 140, 153, 153, 200, 162, 161, 60, 40, 237, 41, 196, 65, 39, 242, 50, 3, 76, 255, 103, 99, 0, 208, 14, 188, 83, 208, 247, 1, 92, 144, 221, 69, 190, 90, 60, 90, 171, 131, 217, 162, 147, 71, 131, 76, 113, 189, 156, 192, 194, 66, 143, 195, 20, 40, 200, 121, 221, 71 },
                            Username = "mikwa"
                        },
                        new
                        {
                            Id = 3,
                            Email = "kakow@gmail.com",
                            FirstName = "Kacper",
                            LastName = "Kowalski",
                            Newsletter = false,
                            Password = "BECBD13041E71F4E4514B2882F4754264C99FD882E5C058E8D11140A6B4ED1F492F9466D2F09BD37B8D3FC4BEDFF7ECFB3A28574D2BB0BD82B931E74F1754F25",
                            Salt = new byte[] { 33, 240, 187, 149, 92, 230, 55, 44, 79, 67, 154, 20, 52, 215, 33, 180, 251, 168, 97, 99, 224, 212, 210, 64, 4, 181, 244, 223, 155, 255, 29, 133, 149, 17, 138, 31, 223, 192, 19, 66, 109, 169, 117, 228, 10, 25, 196, 116, 87, 5, 11, 113, 136, 82, 185, 79, 167, 155, 149, 226, 36, 184, 152, 42 },
                            Username = "kakow"
                        },
                        new
                        {
                            Id = 4,
                            Email = "mateuszlipek@gmail.com",
                            FirstName = "Mateusz",
                            LastName = "Lipek",
                            Newsletter = false,
                            Password = "7AB0A3A79EE86845692B594C90B08CE795B944B55E92AA7E39CD24A4CC8D57D1AE6762FA3C835BF810B04EE0021EC55DB2310C318752E9631145BA3CB37C54FD",
                            Salt = new byte[] { 133, 200, 27, 236, 45, 189, 174, 229, 222, 208, 85, 10, 232, 110, 111, 191, 19, 74, 54, 243, 175, 254, 221, 97, 35, 229, 240, 165, 249, 75, 101, 198, 160, 73, 182, 46, 30, 98, 207, 187, 200, 60, 65, 18, 83, 135, 132, 196, 28, 183, 16, 128, 123, 97, 90, 88, 124, 52, 196, 198, 230, 127, 5, 23 },
                            Username = "lipek"
                        },
                        new
                        {
                            Id = 7,
                            Email = "testminipackage@gmail.com",
                            FirstName = "Mini",
                            LastName = "Package",
                            Newsletter = true,
                            Password = "4F3F90A36B7CE3BADCEA98A7020E927E4091DED377F97E87BA94BF2FDA7932016BF3087B7387F315A80416EC3E75074A04E789A27E51A19403CA0B7B5BC1DE9F",
                            Salt = new byte[] { 168, 85, 190, 56, 31, 199, 167, 42, 34, 141, 18, 52, 133, 178, 173, 252, 97, 55, 169, 216, 22, 255, 244, 196, 45, 75, 98, 120, 246, 99, 145, 59, 40, 200, 27, 117, 23, 140, 209, 22, 85, 119, 72, 41, 110, 65, 154, 249, 30, 142, 146, 49, 254, 142, 191, 2, 80, 186, 229, 30, 236, 150, 22, 253 },
                            Username = "testminipackage"
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
                            Password = "1DF41CFDB63E489BC673A49BE4654B126BE807410B5F5CDBB39C5558CCEDB26D6015D4AC0B1B47891574151B6152BA92B0D22B80B4C2B910CE498E838C87ECA4",
                            Role = "OfficeWorker",
                            Salt = new byte[] { 247, 54, 181, 21, 210, 67, 215, 15, 167, 115, 6, 27, 160, 65, 66, 3, 40, 248, 134, 83, 241, 49, 198, 218, 190, 96, 115, 49, 20, 104, 154, 242, 242, 9, 229, 98, 242, 79, 212, 4, 148, 101, 80, 108, 39, 224, 185, 16, 37, 135, 130, 98, 159, 5, 64, 245, 230, 140, 134, 76, 24, 137, 103, 7 },
                            Username = "janow"
                        },
                        new
                        {
                            Id = 2,
                            Email = "frwys@gmail.com",
                            FirstName = "Franek",
                            LastName = "Wyszomierski",
                            Password = "81846A1E5B13CF136BB1D1F5B7FE96996066A643FBD5910BDEA788C09A5436406704F4DC6DACA0AFD7F2DBB323E5773135F0F2A1FC527198AC5CE35415144405",
                            Role = "Courier",
                            Salt = new byte[] { 13, 10, 165, 67, 233, 19, 109, 130, 105, 205, 123, 200, 65, 68, 179, 221, 233, 57, 234, 193, 54, 136, 94, 68, 79, 213, 184, 224, 125, 48, 143, 107, 241, 16, 10, 123, 148, 196, 208, 138, 15, 149, 21, 246, 7, 28, 154, 115, 234, 151, 76, 198, 37, 141, 218, 214, 206, 249, 10, 93, 160, 102, 122, 55 },
                            Username = "frwys"
                        },
                        new
                        {
                            Id = 3,
                            Email = "igzal@gmail.com",
                            FirstName = "Ignacy",
                            LastName = "Zalewski",
                            Password = "F0475407B7A4EAE26668A8A7F91A9801AAC9ECF4BB8B2936853EC849A41F2480962499BD1216907624C0949B822030841EDE6F2EA797C43F0EC5B429069F8B22",
                            Role = "Courier",
                            Salt = new byte[] { 119, 237, 176, 145, 229, 189, 237, 245, 152, 143, 231, 26, 80, 222, 154, 34, 17, 115, 64, 188, 28, 127, 165, 179, 69, 75, 188, 152, 90, 71, 24, 227, 25, 173, 87, 235, 23, 43, 208, 92, 200, 112, 134, 72, 242, 168, 39, 21, 92, 254, 202, 187, 82, 138, 235, 165, 0, 60, 167, 242, 41, 160, 51, 78 },
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

                    b.Property<decimal>("DisplayPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("display_price");

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
                            DisplayPrice = 130m,
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
                            DisplayPrice = 450m,
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
                            DisplayPrice = 370m,
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
                            DisplayPrice = 880m,
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
                            InquireId = 1,
                            OfferStatus = "AtWarehouse",
                            Price = 100m,
                            TeamName = "MiNIPackage"
                        },
                        new
                        {
                            OfferId = 2,
                            CourierId = 3,
                            InquireId = 4,
                            OfferStatus = "OfferStatusEnum",
                            Price = 70.23m,
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
