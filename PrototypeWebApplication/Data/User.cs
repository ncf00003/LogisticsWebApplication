using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototypeWebApplication.Data;

public partial class User
{
    public int Userid { get; set; }

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    //public string Password { get; set; } = null!;

    //where we were running into issues as this is a Collate
    public byte[] Password { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public string Address { get; set; } = null!;
    
    
    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
    
    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
