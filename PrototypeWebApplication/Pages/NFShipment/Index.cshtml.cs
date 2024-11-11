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
    public class IndexModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.ApplicationDbContext _context;

        public IndexModel(PrototypeWebApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Shipment> Shipment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Shipment = await _context.Shipment.ToListAsync();
        }
    }
}
