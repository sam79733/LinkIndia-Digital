﻿// <auto-generated />
using System;
using LinkIndia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LinkIndia.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("LinkIndia.Models.Client_LoadReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Add_Line1")
                        .HasColumnType("text");

                    b.Property<string>("Add_Line2")
                        .HasColumnType("text");

                    b.Property<string>("AddressProof")
                        .HasColumnType("text");

                    b.Property<string>("BusinessAddressProof")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .HasColumnType("text");

                    b.Property<string>("Pancard")
                        .HasColumnType("text");

                    b.Property<string>("Selfie")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("TransportName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("client_LoadRegs");
                });

            modelBuilder.Entity("LinkIndia.Models.MaterialType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MaterialTypes")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("materialTypes");
                });

            modelBuilder.Entity("LinkIndia.Models.PostLoad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("LoadFrom")
                        .HasColumnType("text");

                    b.Property<string>("LoadTo")
                        .HasColumnType("text");

                    b.Property<string>("MaterialType")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfTrucks")
                        .HasColumnType("int");

                    b.Property<string>("TruckCapacity")
                        .HasColumnType("text");

                    b.Property<int>("TruckSubType")
                        .HasColumnType("int");

                    b.Property<int>("TruckType")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("postLoads");
                });

            modelBuilder.Entity("LinkIndia.Models.PostTruck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AddharNumber")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .HasColumnType("text");

                    b.Property<string>("OwnerName")
                        .HasColumnType("text");

                    b.Property<string>("RCBack")
                        .HasColumnType("text");

                    b.Property<string>("RCFront")
                        .HasColumnType("text");

                    b.Property<string>("RouteFrom")
                        .HasColumnType("text");

                    b.Property<string>("RouteTo")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<int>("TruckSubTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TruckTypeId")
                        .HasColumnType("int");

                    b.Property<string>("VehicleNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("postTrucks");
                });

            modelBuilder.Entity("LinkIndia.Models.TransporterReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Add_Line1")
                        .HasColumnType("text");

                    b.Property<string>("Add_Line2")
                        .HasColumnType("text");

                    b.Property<string>("AddressProof")
                        .HasColumnType("text");

                    b.Property<string>("BusinessAddressProof")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .HasColumnType("text");

                    b.Property<string>("Pancard")
                        .HasColumnType("text");

                    b.Property<string>("Selfie")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("TransportName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("transporterRegs");
                });

            modelBuilder.Entity("LinkIndia.Models.TruckOwnerReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Add_Line1")
                        .HasColumnType("text");

                    b.Property<string>("Add_Line2")
                        .HasColumnType("text");

                    b.Property<string>("AddressProof")
                        .HasColumnType("text");

                    b.Property<string>("BusinessAddressProof")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .HasColumnType("text");

                    b.Property<string>("Pancard")
                        .HasColumnType("text");

                    b.Property<string>("Selfie")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("truckOwnerRegs");
                });

            modelBuilder.Entity("LinkIndia.Models.TruckSubTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SubType")
                        .HasColumnType("text");

                    b.Property<int>("TruckTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TruckTypeId");

                    b.ToTable("trucksubTypes");
                });

            modelBuilder.Entity("LinkIndia.Models.TruckType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("truckTypes");
                });

            modelBuilder.Entity("LinkIndia.Models.TruckSubTypes", b =>
                {
                    b.HasOne("LinkIndia.Models.TruckType", null)
                        .WithMany("TruckSubTypes")
                        .HasForeignKey("TruckTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LinkIndia.Models.TruckType", b =>
                {
                    b.Navigation("TruckSubTypes");
                });
#pragma warning restore 612, 618
        }
    }
}