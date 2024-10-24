using System;
using System.Collections.Generic;

namespace PrototypeWebApplication.Data;

public partial class Route
{
    public int Routeid { get; set; }

    public string Origin { get; set; } = null!;

    public string Destination { get; set; } = null!;

    public decimal Distance { get; set; }

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
