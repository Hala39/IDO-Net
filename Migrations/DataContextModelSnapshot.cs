﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Entities.AppTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Importance")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("estimatedTime")
                        .HasColumnType("int");

                    b.Property<int>("estimationUnit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = -7,
                            Category = "Education",
                            Date = new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8429),
                            DueDate = new DateTime(2022, 7, 28, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8258),
                            Importance = 2,
                            Status = 0,
                            Title = "Prepare the essay",
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            estimatedTime = 6,
                            estimationUnit = 1
                        },
                        new
                        {
                            Id = -6,
                            Category = "Maintenance",
                            Date = new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8446),
                            DueDate = new DateTime(2022, 8, 7, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8311),
                            Importance = 0,
                            Status = 0,
                            Title = "Format the PC",
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            estimatedTime = 3,
                            estimationUnit = 1
                        },
                        new
                        {
                            Id = -5,
                            Category = "Maintenance",
                            Date = new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8453),
                            DueDate = new DateTime(2022, 7, 27, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8316),
                            Importance = 1,
                            Status = 0,
                            Title = "Contact the support team of XYZ software to ask about the guarantee pricing",
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            estimatedTime = 30,
                            estimationUnit = 0
                        },
                        new
                        {
                            Id = -4,
                            Category = "Work",
                            Date = new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8460),
                            DueDate = new DateTime(2022, 8, 10, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8320),
                            Importance = 0,
                            Status = 0,
                            Title = "Translate the resume",
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            estimatedTime = 2,
                            estimationUnit = 1
                        },
                        new
                        {
                            Id = -3,
                            Category = "Maintenance",
                            Date = new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8465),
                            Importance = 1,
                            Status = 0,
                            Title = "Fix the power button of the TV",
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            estimatedTime = 1,
                            estimationUnit = 1
                        },
                        new
                        {
                            Id = -2,
                            Category = "Work",
                            Date = new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8472),
                            DueDate = new DateTime(2022, 8, 2, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8332),
                            Importance = 2,
                            Status = 0,
                            Title = "Prepare the XD design",
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            estimatedTime = 8,
                            estimationUnit = 2
                        },
                        new
                        {
                            Id = -1,
                            Category = "Education",
                            Date = new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8477),
                            Importance = 0,
                            Status = 0,
                            Title = "Email the faculity director about the progress",
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            estimatedTime = 15,
                            estimationUnit = 0
                        });
                });

            modelBuilder.Entity("API.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9007988c-cd03-434e-8d65-12f9bf7eb601",
                            Email = "user@ido.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEBYv17Yw9LRJALhOseX3QjpAuNKgKZB7/LTxedOtLwQgDihsJ4TWkL2f1WRqDDhEsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f0e7e8f3-30ff-4796-9442-c6e58cff6172",
                            TwoFactorEnabled = false,
                            UserName = "IDO User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("API.Entities.AppTask", b =>
                {
                    b.HasOne("API.Entities.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.User", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
