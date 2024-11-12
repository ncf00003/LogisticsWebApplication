using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.ShipmentCrud
{
    public class CreateModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.LogisticsWebDataContext _context;

        public CreateModel(PrototypeWebApplication.Data.LogisticsWebDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DestinationLocationId"] = new SelectList(_context.Locations, "Locationid", "Locationid");
        ViewData["OriginLocationId"] = new SelectList(_context.Locations, "Locationid", "Locationid");
        ViewData["RouteId"] = new SelectList(_context.Routes, "Routeid", "Routeid");
        ViewData["UserId"] = new SelectList(_context.Users, "Userid", "Userid");
        ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Vehicleid", "Vehicleid");
        ViewData["WarehouseId"] = new SelectList(_context.Warehouses, "Warehouseid", "Warehouseid");
            return Page();
        }

        [BindProperty]
        public Shipment Shipment { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Shipments.Add(Shipment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
