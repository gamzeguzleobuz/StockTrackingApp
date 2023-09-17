using Microsoft.AspNetCore.Mvc;
using StockTrackingApp.Context;
using StockTrackingApp.Data;

namespace StockTrackingApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly StockDbContext _db;

        public CategoryController(StockDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Categories.ToList());
        }

        public IActionResult ProductList()
        {
            return View(_db.Products.ToList());
        }

        public IActionResult ClientList()
        {
            return View(_db.Clients.ToList());
        }

        public IActionResult SaleList()
        {
            return View(_db.Sales.ToList());
        }
    }
}
