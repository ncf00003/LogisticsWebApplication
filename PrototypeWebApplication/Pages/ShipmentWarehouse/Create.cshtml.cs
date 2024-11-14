using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.ShipmentsWarehouse
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
        ViewData["LocationId"] = new SelectList(_context.Locations, "Locationid", "Locationid");
            return Page();
        }

        [BindProperty]
        public Warehouse Warehouse { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Warehouses.Add(Warehouse);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
