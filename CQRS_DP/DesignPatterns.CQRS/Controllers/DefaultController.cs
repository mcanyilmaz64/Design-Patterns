using DesignPatterns.CQRS.CQRSDesignPattern.Commands;
using DesignPatterns.CQRS.CQRSDesignPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler )
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddProduct(CreateProductCommand command)
		{
            _createProductCommandHandler.Handle(command);
			return RedirectToAction("Index");
		}
	}
}
