using Business.Concrete;
using Business.ValidationRules;
using Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace WebApp.Controllers
{
    public class SalesController : Controller
    {
        SalesManager salesManager = new SalesManager();
        ProductManager productManager = new ProductManager();
        CustomerManager customerManager = new CustomerManager();
        StockManager stockManager = new StockManager();
        StockValidator stockValidator = new StockValidator();
        public IActionResult Index()
        {
            var sales = salesManager.GetAll();
            foreach (var item in sales)
            {
                var product = productManager.GetById(item.Product_Id);
                var customer = customerManager.GetById(item.Customer_Id);
                item.Product = product;
                item.Customer = customer;
            }
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
            var productStock = stockManager.GetByProductId(sales.Product_Id);
            productStock.Quantity -= sales.Quantity;
            ValidationResult validationResult = stockValidator.Validate(productStock);
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            else
            {
                stockManager.Update(productStock);
                salesManager.Add(sales);
            }
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
