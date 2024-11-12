using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;

namespace PrototypeWebApplication.Pages.NFShipment
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public IList<Shipment> Shipment { get;set; } = default!;
        /*
        public async Task OnGetAsync()
        {
            Shipment = await _context.Shipment.ToListAsync();
        }
        */
        public async Task<IActionResult> OnGetAsync(string Userid)
        {
            if (string.IsNullOrEmpty(Userid))
            {
                return Page();
            }

            try
            {
                // make the endpoint string we want to hit
                string requestUrl = $"https://localhost:7144/api/Shipment/getallbyuser?Userid={Uri.EscapeDataString(Userid)}";

                // Send the GET request to the API
                Shipment = await _httpClient.GetFromJsonAsync<IList<Shipment>>(requestUrl) ?? new List<Shipment>();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
            return Page();
            }   
        }
}

