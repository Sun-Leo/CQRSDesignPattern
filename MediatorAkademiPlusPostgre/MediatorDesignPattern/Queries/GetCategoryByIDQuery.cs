using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Queries
{
    public class GetCategoryByIDQuery: IRequest<GetCategoryByIDResult>
    {
        public GetCategoryByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
