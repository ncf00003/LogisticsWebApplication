/* 
 * Add all off your using statements and register service with application through program.cs file
 */
using Microsoft.AspNetCore.Mvc;

namespace LogisticsWebAppAPI.Controllers
{
    public class NFVehicleDriverController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
