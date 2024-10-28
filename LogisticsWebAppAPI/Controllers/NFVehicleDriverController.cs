/* 
 * Add all off your using statements!!! then register service with application through program.cs file
 * Document Readme later. 
 */
using LogisticsWebAppAPI.Repositories;
using LogisticsWebAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace LogisticsWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class NFVehicleDriverController : ControllerBase
    {
        // be extra carefull with names between files
        private readonly INFVehicleDriver NFVehicleDriverService;
        public NFVehicleDriverController(INFVehicleDriver VehicleDriverService)
        {
            this.NFVehicleDriverService = VehicleDriverService;
        }
        [HttpGet("GetVehicleDriver")]
        public async Task<IEnumerable<Vehicle>> VehicleGetDriver(int vehicleId)
        {
            try
            {
                var response = await NFVehicleDriverService.VehicleGetDriver(vehicleId);
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
