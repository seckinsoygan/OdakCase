using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();

        public IActionResult Index()
        {
            var products = productManager.GetAll();
            foreach (var item in products)
            {
                var category = categoryManager.Get(item.Category_Id);
                item.Category = category;
            }
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
        [HttpGet]
        public IActionResult Update(int id)
        {
            var productValue = productManager.GetById(id);
            return View(productValue);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            productManager.Update(product);
            return RedirectToAction("Index");
        }
    }
}
