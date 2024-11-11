using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.NFShipment
{
    public class DetailsModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.ApplicationDbContext _context;

        public DetailsModel(PrototypeWebApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Shipment Shipment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipment = await _context.Shipment.FirstOrDefaultAsync(m => m.Shipmentid == id);
            if (shipment == null)
            {
                return NotFound();
            }
            else
            {
                Shipment = shipment;
            }
            return Page();
        }
    }
}
