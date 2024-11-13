using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.ShipmentType
{
    public class DetailsModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.LogisticsWebDataContext _context;

        public DetailsModel(PrototypeWebApplication.Data.LogisticsWebDataContext context)
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

            var shipment = await _context.Shipments.FirstOrDefaultAsync(m => m.Shipmentid == id);
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
