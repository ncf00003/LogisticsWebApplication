using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.ShipmentsWarehouse
{
    public class DetailsModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.LogisticsWebDataContext _context;

        public DetailsModel(PrototypeWebApplication.Data.LogisticsWebDataContext context)
        {
            _context = context;
        }

        public Warehouse Warehouse { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warehouse = await _context.Warehouses.FirstOrDefaultAsync(m => m.Warehouseid == id);
            if (warehouse == null)
            {
                return NotFound();
            }
            else
            {
                Warehouse = warehouse;
            }
            return Page();
        }
    }
}
