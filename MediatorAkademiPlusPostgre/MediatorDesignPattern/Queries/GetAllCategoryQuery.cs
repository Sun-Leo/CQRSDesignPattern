using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Queries
{
    public class GetAllCategoryQuery: IRequest<List<GetAllCategoryResult>>
    {

    }
}
