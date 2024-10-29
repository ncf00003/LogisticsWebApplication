// Always register service with the program "add scoped service" 
using LogisticsWebAppAPI.Repositories;
using LogisticsWebAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace LogisticsWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class NFDeliveryTrackingController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        } */
        private readonly INFDeliveryTracking NFDeliveryTrackingService;

        public NFDeliveryTrackingController(INFDeliveryTracking DeliveryTrackingService)
        {
            this.NFDeliveryTrackingService = DeliveryTrackingService;
        }
        /* Read all Shipment Information
         * Figure out web testing later
         */

        [HttpGet("GetShipmentId")]
        // Get specific info on shipment
        public async Task<IEnumerable<DeliveryShipment>> GetShipmentIdAsync(int ShipmentId, int userId)
        {
            try
            {
                var response = await NFDeliveryTrackingService.GetShipmentIdAsync(ShipmentId, userId);
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
