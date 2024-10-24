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
