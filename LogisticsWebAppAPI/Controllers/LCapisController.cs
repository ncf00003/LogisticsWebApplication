using LogisticsWebAppAPI.Repositories;
using LogisticsWebAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace LogisticsWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // Added controller for LCApis
    public class LCapisController : ControllerBase
    {
        // Added service reference for ILCApisInterface
        private readonly ILCApisInterface LCService;

        // Added constructor for LCApisController
        public LCapisController(ILCApisInterface LCservice)
        {
            // Added service reference for ILCApisInterface
            this.LCService = LCservice;
        }


        [HttpPost("ShipmentAdd")]
        // Create a shipment using the Shipment class
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
        // Get sum (count) the shipments in the warehouse
        [HttpGet("SumShipmentsWarehouse")]
        // Get the sum (count) of shipments in the warehouse using the ShipmentsWarehouse class
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
