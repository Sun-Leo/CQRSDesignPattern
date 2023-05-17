using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class AddProductCommandHandler
    {
        private readonly Context _context;

        public AddProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(AddProductCommand addProductCommand)
        {
            _context.Products.Add(new Product
            {
                ProductBrand = addProductCommand.ProductBrand,
                ProductName = addProductCommand.ProductName,
                ProductCategory = addProductCommand.ProductCategory,
                ProductPrice = addProductCommand.ProductPrice,
                Tax = addProductCommand.Tax,
                ProductStock = addProductCommand.ProductStock,
                ProductStockType = addProductCommand.ProductStockType,
                Barcode = addProductCommand.Barcode,
                LastUseDate = addProductCommand.LastUseDate,
                Publisher = addProductCommand.Publisher,
                ShelfNumber = addProductCommand.ShelfNumber,
            });
            _context.SaveChanges();
           
        }
    }
}
