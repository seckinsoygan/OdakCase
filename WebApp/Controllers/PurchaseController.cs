using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PurchaseController : Controller
    {
        PurchaseManager purchaseManager = new PurchaseManager();
        CustomerManager customerManager = new CustomerManager();
        ProductManager productManager = new ProductManager();
        public IActionResult Index()
        {
            var purchases = purchaseManager.GetAll();
            foreach (var item in purchases)
            {
                var Customer = customerManager.GetById(item.Customer_Id);
                var Product = productManager.GetById(item.Product_Id);
                item.Customer = Customer;
                item.Product = Product;
            }
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
