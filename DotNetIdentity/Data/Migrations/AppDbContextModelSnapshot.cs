﻿// <auto-generated />
using System;
using DotNetIdentity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable
#pragma warning disable 1591
namespace DotNetIdentity.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotNetIdentity.Models.DataModels.ApplicationSettings", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Type")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Name", "Type");

                    b.ToTable("AppSettings");

                    b.HasData(
                        new
                        {
                            Name = "SessionTimeoutWarnAfter",
                            Type = "GlobalSettings",
                            Value = "50000"
                        },
                        new
                        {
                            Name = "SessionTimeoutRedirAfter",
                            Type = "GlobalSettings",
                            Value = "70000"
                        },
                        new
                        {
                            Name = "SessionCookieExpiration",
                            Type = "GlobalSettings",
                            Value = "7"
                        },
                        new
                        {
                            Name = "Username",
                            Type = "MailSettings",
                            Value = "YOUR_Smtp_Username"
                        },
                        new
                        {
                            Name = "Password",
                            Type = "MailSettings",
                            Value = "YOUR_SmtpPassword"
                        },
                        new
                        {
                            Name = "SmtpServer",
                            Type = "MailSettings",
                            Value = "YOUR_SmtpServer"
                        },
                        new
                        {
                            Name = "SmtpPort",
                            Type = "MailSettings",
                            Value = "587"
                        },
                        new
                        {
                            Name = "SmtpUseTls",
                            Type = "MailSettings",
                            Value = "true"
                        },
                        new
                        {
                            Name = "SmtpFromAddress",
                            Type = "MailSettings",
                            Value = "YOUR_From_Address"
                        },
                        new
                        {
                            Name = "LdapDomainController",
                            Type = "LdapSettings",
                            Value = "YOUR_Domaincontroller_FQDN"
                        },
                        new
                        {
                            Name = "LdapDomainName",
                            Type = "LdapSettings",
                            Value = "YOUR_Domainname"
                        },
                        new
                        {
                            Name = "LdapBaseDn",
                            Type = "LdapSettings",
                            Value = "DC=YOUR,DC=Domain,DC=com"
                        },
                        new
                        {
                            Name = "LdapGroup",
                            Type = "LdapSettings",
                            Value = "YOUR_Ldap_Group"
                        },
                        new
                        {
                            Name = "LdapEnabled",
                            Type = "LdapSettings",
                            Value = "true"
                        },
                        new
                        {
                            Name = "ApplicationName",
                            Type = "BrandSettings",
                            Value = "YourApp"
                        },
                        new
                        {
                            Name = "ColorPrimary",
                            Type = "BrandSettings",
                            Value = "#090251"
                        },
                        new
                        {
                            Name = "ColorSecondary",
                            Type = "BrandSettings",
                            Value = "#f5023c"
                        },
                        new
                        {
                            Name = "ColorInfo",
                            Type = "BrandSettings",
                            Value = "#2196f3"
                        },
                        new
                        {
                            Name = "ColorSuccess",
                            Type = "BrandSettings",
                            Value = "#00c853"
                        },
                        new
                        {
                            Name = "ColorWarning",
                            Type = "BrandSettings",
                            Value = "#ff9800"
                        },
                        new
                        {
                            Name = "ColorDanger",
                            Type = "BrandSettings",
                            Value = "#f5023c"
                        },
                        new
                        {
                            Name = "ColorLightBackground",
                            Type = "BrandSettings",
                            Value = "#f2f7ff"
                        },
                        new
                        {
                            Name = "ColorLink",
                            Type = "BrandSettings",
                            Value = "#f5023c"
                        },
                        new
                        {
                            Name = "ColorHeadlines",
                            Type = "BrandSettings",
                            Value = "#090251"
                        },
                        new
                        {
                            Name = "ColorTextMuted",
                            Type = "BrandSettings",
                            Value = "#a0aabb"
                        });
                });

            modelBuilder.Entity("DotNetIdentity.Models.DataModels.AppLogs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Exception")
                        .HasColumnType("longtext");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MessageTemplate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("AppLogs");
                });

            modelBuilder.Entity("DotNetIdentity.Models.DataModels.SessionCache", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("AbsoluteExpiration")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ExpiresAtTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SlidingExpirationInSeconds")
                        .HasColumnType("int");

                    b.Property<byte[]>("Value")
                        .HasColumnType("longblob");

                    b.HasKey("id");

                    b.ToTable("AppSessionCache");
                });

            modelBuilder.Entity("DotNetIdentity.Models.Identity.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dffc6dd5-b145-41e9-a861-c87ff673e9ca",
                            ConcurrencyStamp = "7b3855c7-17fa-4ff9-a55d-1666539bcfc2",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "f8a527ac-d7f6-4d9d-aca6-46b2261b042b",
                            ConcurrencyStamp = "cab8ac7d-57c4-4337-9663-ef7205853e7e",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "g7a527ac-d7t6-4d7z-aca6-45t2261b042b",
                            ConcurrencyStamp = "94ec1cb6-a8a5-4d4f-92e1-3a2c255b7785",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "p9a527ac-d77w-4d3r-aca6-35b2261b042b",
                            ConcurrencyStamp = "976c32e3-74b8-43c6-af29-3940e5fc45b4",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        });
                });

            modelBuilder.Entity("DotNetIdentity.Models.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Department")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsLdapLogin")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsMfaForce")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("longtext");

                    b.Property<string>("RolesCombined")
                        .HasColumnType("longtext");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TwoFactorType")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6fbfb682-568c-4f5b-a298-85937ca4f7f3",
                            AccessFailedCount = 0,
                            BirthDay = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "c6580361-31ef-4dd7-8c35-b7cbc448992b",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "",
                            Email = "super.admin@local.app",
                            EmailConfirmed = true,
                            FirstName = "Super",
                            Gender = 0,
                            IsEnabled = true,
                            IsLdapLogin = false,
                            IsMfaForce = false,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPER.ADMIN@LOCAL.APP",
                            NormalizedUserName = "SUPER.ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEFB0ktbNWIyN69krllZs74H9IJKJSg5+mzlXgnsJys6+qGtcnBrVurKB21CJhDalyQ==",
                            PhoneNumberConfirmed = false,
                            RolesCombined = "Admin",
                            SecurityStamp = "5ba122e2-2d03-4a95-9df8-423a295659b8",
                            TwoFactorEnabled = false,
                            TwoFactorType = 0,
                            UserName = "super.admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "6fbfb682-568c-4f5b-a298-85937ca4f7f3",
                            RoleId = "dffc6dd5-b145-41e9-a861-c87ff673e9ca"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("DotNetIdentity.Models.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DotNetIdentity.Models.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DotNetIdentity.Models.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("DotNetIdentity.Models.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotNetIdentity.Models.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DotNetIdentity.Models.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618, 1591
        }
    }
}
