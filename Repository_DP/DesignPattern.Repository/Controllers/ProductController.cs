using DesignPattern.Repository.Business.Abstract;
using DesignPattern.Repository.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Repository.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetAll();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var values = _productService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var product = _productService.TGetById(id);
            _productService.TDelete(product);
            return RedirectToAction("Index");
        }
    }
}
