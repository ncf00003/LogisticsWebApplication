// Always register service with the program "add scoped service" 
using LogisticsWebAppAPI.Data;
using LogisticsWebAppAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

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

        public NFDeliveryTrackingController(INFDeliveryTracking NFDeliveryTrackingService)
        {
            this.NFDeliveryTrackingService = NFDeliveryTrackingService;
        }
        /* // Read all Shipment Information
         * [HttpGet("getproductlist")]
        public async Task<List<Product>> GetProductListAsync()
        {
            try
            {
                return await productService.GetProductListAsync();
            }
            catch
            {
                throw;
            }
        }
         */

        [HttpGet("GetShipmentId")]
        // Get specific info on shipment
        public async Task<IEnumerable<Shipment>?> GetShipmentIdAsync(int ShipmentId, int userId)
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
