using Microsoft.AspNetCore.Mvc;

namespace LogisticsWebAppAPI.Controllers
{
    public class NFDeliveryTrackingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
