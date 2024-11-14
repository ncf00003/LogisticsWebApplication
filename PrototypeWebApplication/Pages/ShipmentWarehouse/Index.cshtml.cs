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
    public class IndexModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.LogisticsWebDataContext _context;

        public IndexModel(PrototypeWebApplication.Data.LogisticsWebDataContext context)
        {
            _context = context;
        }

        public IList<Warehouse> Warehouse { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Warehouse = await _context.Warehouses
                .Include(w => w.Location).ToListAsync();
        }
    }
}
