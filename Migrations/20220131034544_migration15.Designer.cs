// <auto-generated />
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
    [Migration("20220131034544_migration15")]
    partial class migration15
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

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemCode");

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

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemsItemCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("PickupAddressAddressId")
                        .HasColumnType("int");

                    b.Property<string>("PickupInstruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("requestedPickupTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShipperOrderId");

                    b.HasIndex("DeliveryAddressAddressId");

                    b.HasIndex("ItemsItemCode");

                    b.HasIndex("PickupAddressAddressId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShippingOrders.Models.Orders", b =>
                {
                    b.HasOne("ShippingOrders.Models.Address", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressAddressId");

                    b.HasOne("ShippingOrders.Models.Items", "Items")
                        .WithMany("Orders")
                        .HasForeignKey("ItemsItemCode");

                    b.HasOne("ShippingOrders.Models.Address", "PickupAddress")
                        .WithMany()
                        .HasForeignKey("PickupAddressAddressId");

                    b.Navigation("DeliveryAddress");

                    b.Navigation("Items");

                    b.Navigation("PickupAddress");
                });

            modelBuilder.Entity("ShippingOrders.Models.Items", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
