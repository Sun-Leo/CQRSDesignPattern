using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Hanslers
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand>
    {
        private readonly Context _context;

        public RemoveCategoryCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
           var value= await _context.Categories.FindAsync(request.Id);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
