using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototypeWebApplication.Data;

public partial class Route
{
    public int Routeid { get; set; }

    public string Origin { get; set; } = null!;

    public string Destination { get; set; } = null!;

    public decimal Distance { get; set; }

    // add above every ICollection
    //[NotMapped]
    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
