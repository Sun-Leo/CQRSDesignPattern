using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductByIDQueryResult
            {
                ProductBrand = value.ProductBrand,
                ProductName = value.ProductName,
                ProductCategory = value.ProductCategory,
                ProductID = value.ProductID,
                ProductPrice = value.ProductPrice,
                ProductStock = value.ProductStock,
                ProductStockType = value.ProductStockType,
                Tax = value.Tax,
                Publisher = value.Publisher,
                ShelfNumber = value.ShelfNumber,
                LastUseDate = value.LastUseDate,
                Barcode = value.Barcode
            };
        }
    }
}
