using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Queries;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Hanslers
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, List<GetAllCategoryResult>>
    {
        private readonly Context _context;

        public GetAllCategoryQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllCategoryResult>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return await _context.Categories.Select(x => new GetAllCategoryResult
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName
            }).ToListAsync();
        }
    }
}
