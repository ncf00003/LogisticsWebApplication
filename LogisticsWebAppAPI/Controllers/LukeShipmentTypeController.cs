using LogisticsWebAppAPI.Repositories;
using LogisticsWebAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace LogisticsWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LukeShipmentTypeController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        } */
        private readonly LukeShipmentTypeInterface lukeShipmentTypeService;

        public LukeShipmentTypeController(LukeShipmentTypeInterface lukeShipmentTypeService)
        {
            this.lukeShipmentTypeService = lukeShipmentTypeService;
        }
        /* Read all Vehicle Information
         * Figure out web testing later
         */

        [HttpGet("ShipmentType")]
        public async Task<IEnumerable<Shipment>> ShipmentType(string shipmentid)
        {
            try
            {
                var response = await lukeShipmentTypeService.ShipmentType(shipmentid);
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