using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
