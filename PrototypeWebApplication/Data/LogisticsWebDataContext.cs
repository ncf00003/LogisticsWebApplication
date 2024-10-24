using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PrototypeWebApplication.Data;

public partial class LogisticsWebDataContext : DbContext
{
    public LogisticsWebDataContext()
    {
    }

    public LogisticsWebDataContext(DbContextOptions<LogisticsWebDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<Tracking> Trackings { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Locationid).HasName("PK__location__306F78A6B4407AEA");

            entity.ToTable("locations");

            entity.Property(e => e.Locationid).HasColumnName("locationid");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.Routeid).HasName("PK__routes__80969725C15F1B88");

            entity.ToTable("routes");

            entity.Property(e => e.Destination).HasMaxLength(255);
            entity.Property(e => e.Distance).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Origin).HasMaxLength(255);
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.HasKey(e => e.Shipmentid).HasName("PK__shipment__5CAE3385E4B2725B");

            entity.ToTable("shipments");

            entity.Property(e => e.Cost).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.DestinationLocationId).HasColumnName("DestinationLocationID");
            entity.Property(e => e.OriginLocationId).HasColumnName("OriginLocationID");
            entity.Property(e => e.RouteId).HasColumnName("routeID");
            entity.Property(e => e.ShipmentType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.VehicleId).HasColumnName("vehicleID");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouseID");
            entity.Property(e => e.Weight).HasColumnType("decimal(6, 2)");

            entity.HasOne(d => d.DestinationLocation).WithMany(p => p.ShipmentDestinationLocations)
                .HasForeignKey(d => d.DestinationLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_DestinationLocation");

            entity.HasOne(d => d.OriginLocation).WithMany(p => p.ShipmentOriginLocations)
                .HasForeignKey(d => d.OriginLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_OriginLocation");

            entity.HasOne(d => d.Route).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_Route");

            entity.HasOne(d => d.User).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_User");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_Vehicle");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipment_Warehouse");
        });

        modelBuilder.Entity<Tracking>(entity =>
        {
            entity.HasKey(e => e.Trackingid).HasName("PK__tracking__A81A70C6529E779E");

            entity.ToTable("tracking");

            entity.HasIndex(e => e.Shipmentid, "UQ__tracking__5CAE33840FCA4FF0").IsUnique();

            entity.Property(e => e.Trackingid).HasColumnName("trackingid");
            entity.Property(e => e.CurrentLocation).HasMaxLength(255);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");

            entity.HasOne(d => d.Shipment).WithOne(p => p.Tracking)
                .HasForeignKey<Tracking>(d => d.Shipmentid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tracking_Shipment");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__tmp_ms_x__CBA1B257EE93BEAA");

            entity.ToTable("users");

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.ContactNumber).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .UseCollation("Latin1_General_BIN2");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Vehicleid).HasName("PK__vehicles__5BE2516AB4535C9A");

            entity.ToTable("vehicles");

            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.DriverId).HasColumnName("driverID");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .HasColumnName("model");
            entity.Property(e => e.Plate)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("plate");
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("vin");

            entity.HasOne(d => d.Driver).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vehicle_Driver");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.Warehouseid).HasName("PK__warehous__102BC9BFA812E5C8");

            entity.ToTable("warehouses");

            entity.Property(e => e.Warehouseid).HasColumnName("warehouseid");
            entity.Property(e => e.Capacity)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("capacity");
            entity.Property(e => e.LocationId).HasColumnName("locationID");

            entity.HasOne(d => d.Location).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Warehouse_Location");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
