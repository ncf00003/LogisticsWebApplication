using System;
using System.Collections.Generic;

namespace PrototypeWebApplication.Data;

public partial class Tracking
{
    public int Trackingid { get; set; }

    public int Shipmentid { get; set; }

    public string CurrentLocation { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public virtual Shipment Shipment { get; set; } = null!;
}
