using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Data;
using System.Net.Http;

namespace PrototypeWebApplication.Pages.ShipmentType
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IList<Shipment> Shipment { get; set; } = new List<Shipment>();

        public async Task<IActionResult> OnGetAsync(string ShipmentType)
        {
          
       
                // make the endpoint string we want to hit
                string requestUrl = $"http://localhost:5272/api/LukeShipmentType/ShipmentType?shipmentid={Uri.EscapeDataString(ShipmentType)}";

                // Send the GET request to the API
                Shipment = await _httpClient.GetFromJsonAsync<IList<Shipment>>(requestUrl) ?? new List<Shipment>();
            
            
            return Page();

        }
    }
}