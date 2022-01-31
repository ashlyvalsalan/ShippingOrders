﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShippingOrders.Data;

namespace ShippingOrders.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220131031546_migration9")]
    partial class migration9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShippingOrders.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suburb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ShippingOrders.Models.Items", b =>
                {
                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrdersShipperOrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemCode");

                    b.HasIndex("OrdersShipperOrderId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ShippingOrders.Models.Orders", b =>
                {
                    b.Property<string>("ShipperOrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DeiiveryInstruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeliveryAddressAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("PickupAddressAddressId")
                        .HasColumnType("int");

                    b.Property<string>("PickupInstruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("requestedPickupTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShipperOrderId");

                    b.HasIndex("DeliveryAddressAddressId");

                    b.HasIndex("PickupAddressAddressId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShippingOrders.Models.Items", b =>
                {
                    b.HasOne("ShippingOrders.Models.Orders", null)
                        .WithMany("Items")
                        .HasForeignKey("OrdersShipperOrderId");
                });

            modelBuilder.Entity("ShippingOrders.Models.Orders", b =>
                {
                    b.HasOne("ShippingOrders.Models.Address", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressAddressId");

                    b.HasOne("ShippingOrders.Models.Address", "PickupAddress")
                        .WithMany()
                        .HasForeignKey("PickupAddressAddressId");

                    b.Navigation("DeliveryAddress");

                    b.Navigation("PickupAddress");
                });

            modelBuilder.Entity("ShippingOrders.Models.Orders", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
