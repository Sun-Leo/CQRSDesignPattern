using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                ProductBrand = value.ProductBrand,
                ProductName = value.ProductName,
                ProductCategory = value.ProductCategory,
                ProductID = value.ProductID,
                ProductPrice = value.ProductPrice,
                ProductStock = value.ProductStock,
                ProductStockType = value.ProductStockType,
                Publisher = value.Publisher,
                Barcode = value.Barcode,
                Tax = value.Tax,
                ShelfNumber = value.ShelfNumber,
                LastUseDate = value.LastUseDate
            };
        }
    }
}
