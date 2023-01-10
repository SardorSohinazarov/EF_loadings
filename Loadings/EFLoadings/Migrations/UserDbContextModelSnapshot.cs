﻿// <auto-generated />
using System;
using EFLoadings.EagerLoading;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFLoadings.Migrations
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.12");

            modelBuilder.Entity("EFLoadings.EagerLoading.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressName = "Farg'ona Buvayda Yangiqishloq"
                        });
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProviderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.HasIndex("UserId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Phone = "+998912040618",
                            ProviderId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Phone = "+998912040618",
                            ProviderId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Providers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Beeline"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ucell"
                        });
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Name = "Buvayda"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 1,
                            Name = "Uchko'prik"
                        });
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Name = "Sardor"
                        });
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.Contact", b =>
                {
                    b.HasOne("EFLoadings.EagerLoading.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFLoadings.EagerLoading.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.Region", b =>
                {
                    b.HasOne("EFLoadings.EagerLoading.Address", "Address")
                        .WithMany("Regions")
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.User", b =>
                {
                    b.HasOne("EFLoadings.EagerLoading.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.Address", b =>
                {
                    b.Navigation("Regions");
                });

            modelBuilder.Entity("EFLoadings.EagerLoading.User", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
