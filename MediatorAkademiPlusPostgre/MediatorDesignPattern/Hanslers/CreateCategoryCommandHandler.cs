using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Hanslers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly Context _context;

        public CreateCategoryCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
             _context.Categories.Add(new Category
            {
                CategoryName = request.CategoryName

            });
            await _context.SaveChangesAsync();
        }
    }
}
