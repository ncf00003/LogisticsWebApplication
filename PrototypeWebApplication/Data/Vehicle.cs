using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototypeWebApplication.Data;

public partial class Vehicle
{
    public int Vehicleid { get; set; }

    public string Model { get; set; } = null!;

    public string Vin { get; set; } = null!;

    public string Plate { get; set; } = null!;

    public int Capacity { get; set; }

    public int DriverId { get; set; }

    public virtual User Driver { get; set; } = null!;
    [NotMapped]
    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
