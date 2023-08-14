using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager();

        public IActionResult Index()
        {
            var products = productManager.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            productManager.Add(product);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var product = productManager.GetById(id);
            productManager.Delete(product);
            return RedirectToAction("Index");
        }
    }
}
