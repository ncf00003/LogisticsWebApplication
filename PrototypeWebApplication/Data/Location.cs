using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototypeWebApplication.Data;

public partial class Location
{
    public int Locationid { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    [NotMapped]
    public virtual ICollection<Shipment> ShipmentDestinationLocations { get; set; } = new List<Shipment>();
    [NotMapped]
    public virtual ICollection<Shipment> ShipmentOriginLocations { get; set; } = new List<Shipment>();
    [NotMapped]
    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
