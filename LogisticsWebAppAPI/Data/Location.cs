using System;
using System.Collections.Generic;

namespace LogisticsWebAppAPI.Data;

public partial class Location
{
    public int Locationid { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public virtual ICollection<Shipment> ShipmentDestinationLocations { get; set; } = new List<Shipment>();

    public virtual ICollection<Shipment> ShipmentOriginLocations { get; set; } = new List<Shipment>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
