using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PurchaseController : Controller
    {
        PurchaseManager purchaseManager = new PurchaseManager();
        public IActionResult Index()
        {
            var purchases = purchaseManager.GetAll();
            return View(purchases);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Purchase purchase)
        {
            purchaseManager.Add(purchase);
            return RedirectToAction("Index");
        }
    }
}
