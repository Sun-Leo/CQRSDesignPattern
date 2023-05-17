using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Hanslers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value=_context.Products.Find(request.ProductID);
            value.ProductName= request.ProductName;
            value.ProductPrice= request.ProductPrice;
            value.ProductStock= request.ProductStock;
            value.ProductBrand= request.ProductBrand;
            value.CategoryID= request.CategoryID;
            _context.Products.Update(value);
            await _context.SaveChangesAsync();
            
        }
    }
}
