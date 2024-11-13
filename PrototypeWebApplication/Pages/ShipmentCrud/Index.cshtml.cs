using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.ShipmentCrud
{
    public class IndexModel : PageModel
    {
        // Going to try to use both database and API
        private readonly PrototypeWebApplication.Data.LogisticsWebDataContext _context;

        public IndexModel(PrototypeWebApplication.Data.LogisticsWebDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IList<Shipment> Shipment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Shipment = await _context.Shipments.ToListAsync();
            // Manually load the related data (workaround for Include)
            
            foreach (var shipment in Shipment)
            {
                shipment.DestinationLocation = await _context.Locations
                    .FirstOrDefaultAsync(l => l.Locationid == shipment.DestinationLocationId);

                shipment.OriginLocation = await _context.Locations
                    .FirstOrDefaultAsync(l => l.Locationid == shipment.OriginLocationId);

                shipment.Warehouse = await _context.Warehouses
                    .FirstOrDefaultAsync(w => w.Warehouseid == shipment.WarehouseId);

                shipment.User = await _context.Users
                    .FirstOrDefaultAsync(u => u.Userid == shipment.UserId);

                shipment.Vehicle = await _context.Vehicles
                    .FirstOrDefaultAsync(v => v.Vehicleid == shipment.VehicleId);

                shipment.Route = await _context.Routes
                    .FirstOrDefaultAsync(r => r.Routeid == shipment.RouteId);
            } 
        

        }
        
    
    }
}
