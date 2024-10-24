using System;
using System.Collections.Generic;

namespace PrototypeWebApplication.Data;

public partial class Warehouse
{
    public int Warehouseid { get; set; }

    public decimal Capacity { get; set; }

    public int? CurrentStock { get; set; }

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
