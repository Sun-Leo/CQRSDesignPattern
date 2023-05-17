using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductID);
            value.ShelfNumber = command.ShelfNumber;
            value.Barcode = command.Barcode;
            value.ProductBrand = command.ProductBrand;
            value.ProductName = command.ProductName;
            value.ProductStock = command.ProductStock;
            value.ProductPrice = command.ProductPrice;
            value.LastUseDate = command.LastUseDate;
            value.ProductCategory = command.ProductCategory;
            value.ProductStockType = command.ProductStockType;
            value.Publisher = command.Publisher;
            value.Tax = command.Tax;
            _context.SaveChanges();
        }
    }
}
