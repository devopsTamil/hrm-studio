﻿// <auto-generated />
using System;
using HRMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRMS.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("HRMS.Entities.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("HRMS.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfileStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<int>("UserStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HRMS.Entities.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("HRMS.Entities.UserAddress", b =>
                {
                    b.Property<string>("UserAddressId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Apartment")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("PinCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("UserAddressId");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("HRMS.Entities.UserBasicInfo", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AadhaarAttachmentUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("AadhaarName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AadhaarNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuardianName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GuardianType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nationality")
                        .HasColumnType("TEXT");

                    b.Property<string>("PANAttachmentUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("PANNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValidVisaInformation")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserBasicInfos");
                });

            modelBuilder.Entity("HRMS.Entities.UserContactInfo", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrespondenceAddressId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhone")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCorrespondenceSameAsPermanent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermanentAddressId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserModified")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("CorrespondenceAddressId")
                        .IsUnique();

                    b.HasIndex("PermanentAddressId")
                        .IsUnique();

                    b.ToTable("UserContactInfos");
                });

            modelBuilder.Entity("HRMS.Entities.UserProfile", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserModified")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HRMS.Entities.ApplicationUserRole", b =>
                {
                    b.HasOne("HRMS.Entities.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMS.Entities.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRMS.Entities.UserBasicInfo", b =>
                {
                    b.HasOne("HRMS.Entities.UserProfile", "UserProfile")
                        .WithOne("UserBasicInfo")
                        .HasForeignKey("HRMS.Entities.UserBasicInfo", "UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRMS.Entities.UserContactInfo", b =>
                {
                    b.HasOne("HRMS.Entities.UserAddress", "CorrespondenceAddress")
                        .WithOne()
                        .HasForeignKey("HRMS.Entities.UserContactInfo", "CorrespondenceAddressId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("HRMS.Entities.UserAddress", "PermanentAddress")
                        .WithOne()
                        .HasForeignKey("HRMS.Entities.UserContactInfo", "PermanentAddressId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("HRMS.Entities.UserProfile", "UserProfile")
                        .WithOne("UserContactInfo")
                        .HasForeignKey("HRMS.Entities.UserContactInfo", "UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRMS.Entities.UserProfile", b =>
                {
                    b.HasOne("HRMS.Entities.ApplicationUser", "User")
                        .WithOne("UserProfile")
                        .HasForeignKey("HRMS.Entities.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("HRMS.Entities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HRMS.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HRMS.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HRMS.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
