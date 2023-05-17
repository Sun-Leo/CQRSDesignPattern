using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Hanslers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly Context _context;

        public UpdateCategoryCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = _context.Categories.Find(request.CategoryID);
            value.CategoryName = request.CategoryName;
            _context.Categories.Update(value);
            await _context.SaveChangesAsync();
            
        }
    }
}
