using FluentValidation.Results;
using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.BusinessLayer.ValidationRules;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var values = productService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        { 
            ProductValidator pv= new ProductValidator();
            ValidationResult result = pv.Validate(p);
            if (result.IsValid)
            {
                productService.Insert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteProduct(int id)
        {
            var urunsil = productService.GetById(id);
            productService.Delete(urunsil);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var urun=productService.GetById(id);
            return View(urun);

        }
        public IActionResult UpdateProduct(Product p)
        {
            productService.Update(p);
            return RedirectToAction("Index");
        }

    }
}
