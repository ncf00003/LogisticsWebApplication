using LogisticsWebAppAPI.Repositories;
using LogisticsWebAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace LogisticsWebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LukeAddVehicleController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        } */
        private readonly LukeAddVehicleInterface LukeAddVehicleService;

        public LukeAddVehicleController(LukeAddVehicleInterface LukeAddVehicleService)
        {
            this.LukeAddVehicleService = LukeAddVehicleService;
        }
        /* Read all Vehicle Information
         * Figure out web testing later
         */

        [HttpPost("AddVehicle")]
        // Get specific info on vehicle
        public async Task<IActionResult> AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return BadRequest();
            }
            try
            {
                var response = await LukeAddVehicleService.AddVehicle(vehicle);
                return Ok(response);
            }
            catch
            {
                throw;
            }
        }
    }
}