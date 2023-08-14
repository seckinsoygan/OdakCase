using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class StockController : Controller
    {
        StockManager stockManager = new StockManager();

        public IActionResult Index()
        {
            var stocks = stockManager.GetAll();
            return View(stocks);
        }
    }
}
