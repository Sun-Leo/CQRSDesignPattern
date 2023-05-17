using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var value= _context.Products.Select(x=> 
            new GetProductQueryResult
            {
                ProductBrand = x.ProductBrand,
                ProductName = x.ProductName,
                ProductCategory = x.ProductCategory,
                ProductID = x.ProductID,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                Publisher = x.Publisher,
                LastUseDate = x.LastUseDate,
                Barcode = x.Barcode,
                ShelfNumber = x.ShelfNumber

            }).ToList();
            return value;
        }
    }
}
