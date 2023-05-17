using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Queries;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Hanslers
{
    public class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, GetProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIDQueryResult> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
        {
            var value= await _context.Products.FindAsync(request.Id);
            return new GetProductByIDQueryResult
            {
                CategoryID = value.CategoryID,
                ProductName = value.ProductName,
                ProductBrand = value.ProductBrand,
                ProductID = value.ProductID,
                ProductPrice = value.ProductPrice,
                ProductStock = value.ProductStock
            };
        }
    }
}
