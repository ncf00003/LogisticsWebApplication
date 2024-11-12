using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.TrackingCrud
{
    public class DeleteModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.LogisticsWebDataContext _context;

        public DeleteModel(PrototypeWebApplication.Data.LogisticsWebDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tracking Tracking { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tracking = await _context.Trackings.FirstOrDefaultAsync(m => m.Trackingid == id);

            if (tracking == null)
            {
                return NotFound();
            }
            else
            {
                Tracking = tracking;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tracking = await _context.Trackings.FindAsync(id);
            if (tracking != null)
            {
                Tracking = tracking;
                _context.Trackings.Remove(Tracking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
