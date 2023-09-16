using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
