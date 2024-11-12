﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrototypeWebApplication.Data;

#nullable disable

namespace PrototypeWebApplication.Migrations
{
    [DbContext(typeof(LogisticsWebDataContext))]
    [Migration("20241112224304_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PrototypeWebApplication.Data.Location", b =>
                {
                    b.Property<int>("Locationid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("locationid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Locationid"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)");

                    b.HasKey("Locationid")
                        .HasName("PK__location__306F78A6B4407AEA");

                    b.ToTable("locations", (string)null);
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Route", b =>
                {
                    b.Property<int>("Routeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Routeid"));

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Distance")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Routeid")
                        .HasName("PK__routes__80969725C15F1B88");

                    b.ToTable("routes", (string)null);
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Shipment", b =>
                {
                    b.Property<int>("Shipmentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shipmentid"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<DateOnly?>("DeliveryDate")
                        .HasColumnType("date");

                    b.Property<int>("DestinationLocationId")
                        .HasColumnType("int")
                        .HasColumnName("DestinationLocationID");

                    b.Property<int>("OriginLocationId")
                        .HasColumnType("int")
                        .HasColumnName("OriginLocationID");

                    b.Property<int>("RouteId")
                        .HasColumnType("int")
                        .HasColumnName("routeID");

                    b.Property<string>("ShipmentType")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userID");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int")
                        .HasColumnName("vehicleID");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int")
                        .HasColumnName("warehouseID");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("Shipmentid")
                        .HasName("PK__shipment__5CAE3385E4B2725B");

                    b.HasIndex("DestinationLocationId");

                    b.HasIndex("OriginLocationId");

                    b.HasIndex("RouteId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("shipments", (string)null);
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Tracking", b =>
                {
                    b.Property<int>("Trackingid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("trackingid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Trackingid"));

                    b.Property<string>("CurrentLocation")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Shipmentid")
                        .HasColumnType("int");

                    b.HasKey("Trackingid")
                        .HasName("PK__tracking__A81A70C6529E779E");

                    b.HasIndex(new[] { "Shipmentid" }, "UQ__tracking__5CAE33840FCA4FF0")
                        .IsUnique();

                    b.ToTable("tracking", (string)null);
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("userid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Userid"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .UseCollation("Latin1_General_BIN2");

                    b.HasKey("Userid")
                        .HasName("PK__tmp_ms_x__CBA1B257EE93BEAA");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Vehicle", b =>
                {
                    b.Property<int>("Vehicleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("vehicleid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Vehicleid"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("capacity");

                    b.Property<int>("DriverId")
                        .HasColumnType("int")
                        .HasColumnName("driverID");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("model");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("plate");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasMaxLength(17)
                        .IsUnicode(false)
                        .HasColumnType("varchar(17)")
                        .HasColumnName("vin");

                    b.HasKey("Vehicleid")
                        .HasName("PK__vehicles__5BE2516AB4535C9A");

                    b.HasIndex("DriverId");

                    b.ToTable("vehicles", (string)null);
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Warehouse", b =>
                {
                    b.Property<int>("Warehouseid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("warehouseid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Warehouseid"));

                    b.Property<decimal>("Capacity")
                        .HasColumnType("decimal(6, 2)")
                        .HasColumnName("capacity");

                    b.Property<int?>("CurrentStock")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("locationID");

                    b.HasKey("Warehouseid")
                        .HasName("PK__warehous__102BC9BFA812E5C8");

                    b.HasIndex("LocationId");

                    b.ToTable("warehouses", (string)null);
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Shipment", b =>
                {
                    b.HasOne("PrototypeWebApplication.Data.Location", "DestinationLocation")
                        .WithMany("ShipmentDestinationLocations")
                        .HasForeignKey("DestinationLocationId")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_DestinationLocation");

                    b.HasOne("PrototypeWebApplication.Data.Location", "OriginLocation")
                        .WithMany("ShipmentOriginLocations")
                        .HasForeignKey("OriginLocationId")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_OriginLocation");

                    b.HasOne("PrototypeWebApplication.Data.Route", "Route")
                        .WithMany("Shipments")
                        .HasForeignKey("RouteId")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_Route");

                    b.HasOne("PrototypeWebApplication.Data.User", "User")
                        .WithMany("Shipments")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_User");

                    b.HasOne("PrototypeWebApplication.Data.Vehicle", "Vehicle")
                        .WithMany("Shipments")
                        .HasForeignKey("VehicleId")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_Vehicle");

                    b.HasOne("PrototypeWebApplication.Data.Warehouse", "Warehouse")
                        .WithMany("Shipments")
                        .HasForeignKey("WarehouseId")
                        .IsRequired()
                        .HasConstraintName("FK_Shipment_Warehouse");

                    b.Navigation("DestinationLocation");

                    b.Navigation("OriginLocation");

                    b.Navigation("Route");

                    b.Navigation("User");

                    b.Navigation("Vehicle");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Tracking", b =>
                {
                    b.HasOne("PrototypeWebApplication.Data.Shipment", "Shipment")
                        .WithOne("Tracking")
                        .HasForeignKey("PrototypeWebApplication.Data.Tracking", "Shipmentid")
                        .IsRequired()
                        .HasConstraintName("FK_Tracking_Shipment");

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Vehicle", b =>
                {
                    b.HasOne("PrototypeWebApplication.Data.User", "Driver")
                        .WithMany("Vehicles")
                        .HasForeignKey("DriverId")
                        .IsRequired()
                        .HasConstraintName("FK_Vehicle_Driver");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Warehouse", b =>
                {
                    b.HasOne("PrototypeWebApplication.Data.Location", "Location")
                        .WithMany("Warehouses")
                        .HasForeignKey("LocationId")
                        .IsRequired()
                        .HasConstraintName("FK_Warehouse_Location");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Location", b =>
                {
                    b.Navigation("ShipmentDestinationLocations");

                    b.Navigation("ShipmentOriginLocations");

                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Route", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Shipment", b =>
                {
                    b.Navigation("Tracking");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.User", b =>
                {
                    b.Navigation("Shipments");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Vehicle", b =>
                {
                    b.Navigation("Shipments");
                });

            modelBuilder.Entity("PrototypeWebApplication.Data.Warehouse", b =>
                {
                    b.Navigation("Shipments");
                });
#pragma warning restore 612, 618
        }
    }
}
