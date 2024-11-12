using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototypeWebApplication.Data;

public partial class Shipment
{
    public int Shipmentid { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? ShipmentType { get; set; }

    public decimal Weight { get; set; }

    public decimal Cost { get; set; }

    public int UserId { get; set; }

    public int VehicleId { get; set; }

    public int RouteId { get; set; }

    public int WarehouseId { get; set; }

    public int OriginLocationId { get; set; }

    public int DestinationLocationId { get; set; }
    

    public virtual Location? DestinationLocation { get; set; } = null!;
    
    public virtual Location? OriginLocation { get; set; } = null!;
    
    public virtual Route? Route { get; set; } = null!;
    
    public virtual Tracking? Tracking { get; set; }
    
    public virtual User? User { get; set; } = null!;
   
    public virtual Vehicle? Vehicle { get; set; } = null!;
    
    public virtual Warehouse? Warehouse { get; set; } = null!;
}
