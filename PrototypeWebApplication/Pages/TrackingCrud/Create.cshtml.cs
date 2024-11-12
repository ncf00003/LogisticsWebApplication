using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.TrackingCrud
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
        ViewData["Shipmentid"] = new SelectList(_context.Shipments, "Shipmentid", "Shipmentid");
            return Page();
        }

        [BindProperty]
        public Tracking Tracking { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trackings.Add(Tracking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
