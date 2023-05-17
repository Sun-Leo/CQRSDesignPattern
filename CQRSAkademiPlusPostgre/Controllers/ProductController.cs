using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.CQRSPattern.Handlers;
using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSAkademiPlusPostgre.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly AddProductCommandHandler _addProductCommandHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly GetProductUpdateByIDQueryHandler _getProductUpdateByIDQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public ProductController(GetProductQueryHandler getProductQueryHandler, AddProductCommandHandler addProductCommandHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler, UpdateEmployeeCommandHandler updateEmployeeCommandHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _addProductCommandHandler = addProductCommandHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
            _getProductUpdateByIDQueryHandler = getProductUpdateByIDQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
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
        public IActionResult AddProduct(AddProductCommand addProduct)
        {
            _addProductCommandHandler.Handle(addProduct);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        public IActionResult DetailProduct(int id)
        {
            var value = _getProductByIDQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(value);
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
           var value= _getProductUpdateByIDQueryHandler.Handle(new GetProductUpdateByIDQuery(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand updateProduct)
        {
            _updateProductCommandHandler.Handle(updateProduct);
            return RedirectToAction("Index");
        }
    }
}
