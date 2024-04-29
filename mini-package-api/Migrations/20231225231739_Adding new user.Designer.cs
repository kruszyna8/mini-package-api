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
    [Migration("20231225231739_Adding new user")]
    partial class Addingnewuser
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
                            Password = "2F02438D85C93004CA898F6668B8D5C77EE4B3AA39953F78C40028FD666972DE9BD40F22F66B7F24FFCA80CBC9D051A7D2DE0D8C0227954138D3DD818C98A111",
                            Salt = new byte[] { 168, 124, 240, 78, 209, 24, 117, 29, 9, 224, 137, 187, 159, 100, 250, 207, 117, 25, 203, 12, 118, 22, 166, 7, 207, 155, 82, 226, 135, 223, 19, 166, 144, 24, 12, 149, 104, 161, 189, 69, 34, 226, 185, 156, 217, 36, 234, 145, 20, 178, 61, 66, 205, 16, 112, 189, 88, 26, 182, 177, 205, 2, 45, 254 },
                            Username = "mikwa"
                        },
                        new
                        {
                            Id = 3,
                            Email = "kakow@gmail.com",
                            FirstName = "Kacper",
                            LastName = "Kowalski",
                            Newsletter = false,
                            Password = "C863AD8323E4CCEFFB877B6126B18C8A17C5DED97EC98E67679DE90F860646EF6CB1888FC48699122A908B23F90F43B668E0B96CEB8B061A96ADED7F8D168F91",
                            Salt = new byte[] { 27, 73, 197, 227, 211, 178, 45, 109, 157, 148, 113, 75, 43, 170, 138, 237, 62, 5, 240, 86, 96, 52, 2, 243, 76, 57, 120, 195, 129, 88, 77, 225, 97, 11, 137, 107, 28, 91, 0, 13, 226, 124, 241, 140, 163, 24, 168, 169, 230, 228, 170, 218, 143, 3, 201, 12, 127, 205, 44, 104, 48, 65, 71, 158 },
                            Username = "kakow"
                        },
                        new
                        {
                            Id = 4,
                            Email = "mateuszlipek@gmail.com",
                            FirstName = "Mateusz",
                            LastName = "Lipek",
                            Newsletter = false,
                            Password = "F76D88C12267D28770C1BC3D04A0E2C406E5817A9AD72DA836A319E0E91DDFF12CD595FCDC224D552537BFDF38AA4317325DE4173D09D72253FF25B1DC1D9A6D",
                            Salt = new byte[] { 234, 44, 170, 14, 129, 250, 134, 20, 119, 169, 176, 182, 30, 161, 27, 168, 147, 242, 237, 206, 16, 130, 80, 18, 229, 115, 214, 99, 16, 67, 158, 235, 66, 74, 100, 41, 130, 225, 235, 196, 49, 166, 254, 224, 205, 24, 219, 215, 28, 138, 144, 10, 75, 49, 245, 133, 175, 174, 71, 155, 121, 88, 5, 42 },
                            Username = "lipek"
                        },
                        new
                        {
                            Id = 7,
                            Email = "testminipackage@gmail.com",
                            FirstName = "Mini",
                            LastName = "Package",
                            Newsletter = true,
                            Password = "2BFB5B15BECF0F473EDB18C1375FFB85F9803FC1506E5CB8AC91ECC703DCE19EE06CF142CC99957D71515FF763D74472B9FA6D3B4478AD6415948AE49C47641A",
                            Salt = new byte[] { 49, 0, 18, 92, 91, 81, 92, 166, 11, 45, 105, 101, 241, 29, 228, 196, 133, 215, 91, 239, 244, 230, 199, 17, 52, 110, 222, 61, 60, 121, 8, 150, 202, 85, 139, 199, 74, 14, 72, 154, 21, 133, 92, 61, 46, 136, 238, 56, 105, 1, 40, 191, 134, 247, 251, 32, 220, 148, 107, 214, 86, 113, 98, 187 },
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
                            Password = "F88D817F5384F6C3F2E2BE9D461655F67DA5EE047B8A5D2114B7DD63675E2E94BE035CCE98CE2299AA6F00B1679C4F0319CA4BC910DC69313FFDFE1D1BDDE900",
                            Role = "OfficeWorker",
                            Salt = new byte[] { 1, 217, 236, 34, 158, 203, 136, 147, 146, 47, 253, 58, 4, 32, 147, 5, 137, 254, 176, 131, 50, 80, 129, 244, 247, 182, 119, 18, 241, 126, 222, 205, 144, 159, 119, 24, 188, 80, 160, 82, 59, 63, 193, 20, 182, 144, 60, 36, 81, 211, 130, 179, 28, 132, 116, 146, 108, 13, 25, 145, 115, 19, 194, 128 },
                            Username = "janow"
                        },
                        new
                        {
                            Id = 2,
                            Email = "frwys@gmail.com",
                            FirstName = "Franek",
                            LastName = "Wyszomierski",
                            Password = "B06C7F34ABDBF24FAD169DCEE0FB6D3897D05CDB879C56CEF2CCAEE6A2C4351B672696FB421524BB96A460AB4747C5E8ED2DF3841172A297001B94EAC4C7E12B",
                            Role = "Courier",
                            Salt = new byte[] { 85, 218, 4, 30, 246, 147, 112, 103, 155, 13, 131, 22, 37, 156, 158, 174, 5, 28, 205, 46, 137, 241, 37, 23, 88, 248, 82, 251, 43, 53, 129, 50, 147, 105, 121, 170, 108, 84, 157, 159, 142, 118, 168, 208, 26, 97, 187, 6, 165, 175, 228, 237, 195, 113, 98, 76, 138, 115, 55, 90, 31, 59, 181, 184 },
                            Username = "frwys"
                        },
                        new
                        {
                            Id = 3,
                            Email = "igzal@gmail.com",
                            FirstName = "Ignacy",
                            LastName = "Zalewski",
                            Password = "1598488C4A092DFF2D739CCFCBDE89FF058C37972C07105E1A3A1F17FD9EFDD0B9C230D4FA2CBC1AA9DA7BBD90ED173DEE3773B6F14EABC9FE64ECA77948CECB",
                            Role = "Courier",
                            Salt = new byte[] { 51, 63, 201, 9, 199, 139, 67, 41, 115, 116, 177, 237, 209, 220, 158, 33, 154, 103, 98, 253, 48, 120, 64, 229, 3, 82, 88, 7, 167, 13, 47, 65, 99, 141, 61, 72, 231, 83, 34, 136, 12, 142, 216, 129, 9, 16, 104, 228, 90, 194, 118, 212, 48, 84, 214, 219, 5, 102, 0, 41, 27, 59, 222, 47 },
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
