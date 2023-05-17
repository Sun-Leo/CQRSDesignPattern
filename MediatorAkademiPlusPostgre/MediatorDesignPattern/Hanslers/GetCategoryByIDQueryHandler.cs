using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Queries;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Hanslers
{
    public class GetCategoryByIDQueryHandler : IRequestHandler<GetCategoryByIDQuery, GetCategoryByIDResult>
    {
        private readonly Context _context;

        public GetCategoryByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetCategoryByIDResult> Handle(GetCategoryByIDQuery request, CancellationToken cancellationToken)
        {
            var value= await _context.Categories.FindAsync(request.Id);
            return new GetCategoryByIDResult
            {
                CategoryID = value.CategoryID,
                CategoryName = value.CategoryName
            };
        }
    }
}
