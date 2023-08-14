using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers
{
    public class StockController : Controller
    {
        StockManager stockManager = new StockManager();
        ProductManager productManager = new ProductManager();

        public IActionResult Index()
        {
            var stocks = stockManager.GetAll();
            foreach (var item in stocks)
            {
                var product = productManager.GetById(item.Product_Id);
                item.Product = product;
            }
            return View(stocks);
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> valueProduct = (from x in productManager.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name
                                                 }).ToList();
            ViewBag.vlp = valueProduct;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Stock stock)
        {
            stockManager.Add(stock);
            return RedirectToAction("Index");
        }
    }
}
