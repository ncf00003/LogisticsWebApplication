using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.ShipmentType
{
    public class EditModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.LogisticsWebDataContext _context;

        public EditModel(PrototypeWebApplication.Data.LogisticsWebDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Shipment Shipment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipment =  await _context.Shipments.FirstOrDefaultAsync(m => m.Shipmentid == id);
            if (shipment == null)
            {
                return NotFound();
            }
            Shipment = shipment;
           ViewData["DestinationLocationId"] = new SelectList(_context.Locations, "Locationid", "Locationid");
           ViewData["OriginLocationId"] = new SelectList(_context.Locations, "Locationid", "Locationid");
           ViewData["RouteId"] = new SelectList(_context.Routes, "Routeid", "Routeid");
           ViewData["UserId"] = new SelectList(_context.Users, "Userid", "Userid");
           ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Vehicleid", "Vehicleid");
           ViewData["WarehouseId"] = new SelectList(_context.Warehouses, "Warehouseid", "Warehouseid");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Shipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShipmentExists(Shipment.Shipmentid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShipmentExists(int id)
        {
            return _context.Shipments.Any(e => e.Shipmentid == id);
        }
    }
}
