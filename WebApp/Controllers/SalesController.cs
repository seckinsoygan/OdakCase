using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class SalesController : Controller
    {
        SalesManager salesManager = new SalesManager();

        public IActionResult Index()
        {
            var sales = salesManager.GetAll();
            return View(sales);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Sales sales)
        {
            var discountRate = ((sales.ListPrice - sales.SalesPrice) / sales.ListPrice) * 100;
            sales.Discountrate = discountRate;
            salesManager.Add(sales);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var product = salesManager.GetById(id);
            salesManager.Delete(product);
            return RedirectToAction("Index");
        }
    }
}
