using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.VehicleCRUD
{
    public class IndexModel : PageModel
    {
        private readonly PrototypeWebApplication.Data.LogisticsWebDataContext _context;

        public IndexModel(PrototypeWebApplication.Data.LogisticsWebDataContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicles.ToListAsync();
            //.Include(v => v.Driver).ToListAsync();

            /*foreach (var v in Vehicle)
                {
                    Vehicle.Model = await _context.Vehicles
                        .FirstOrDefaultAsync(v => v.Vehicleid = Vehicle.Model);
                }*/

            foreach (var v in Vehicle)
            {
                v.Model = (await _context.Vehicles
                    .FirstOrDefaultAsync(vInner => vInner.Vehicleid == v.Vehicleid))?.Model;
            }

        }
    }
}
