using LogisticsWebAppAPI.Repositories;
using LogisticsWebAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace LogisticsWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LCapisController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        } */
        private readonly ILCApisInterface LCService;

        public LCapisController(ILCApisInterface LCservice)
        {
            this.LCService = LCservice;
        }
        /* Read all Shipment Information
         * Figure out web testing later
         */

        [HttpPost("ShipmentAdd")]
        // Get specific info on shipment
        public async Task<IActionResult> ShipmentAdd(Shipment shipment)
        {
            if (shipment == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await LCService.ShipmentAdd(shipment);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
        [HttpGet("SumShipmentsWarehouse")]
        public async Task<IEnumerable<ShipmentsWarehouse>> SumShipmentsWarehouse(int warehouseid)
        {
            try
            {
                var response = await LCService.SumShipmentsWarehouse(warehouseid);
                if (response == null)
                {
                    return null;
                }
                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
