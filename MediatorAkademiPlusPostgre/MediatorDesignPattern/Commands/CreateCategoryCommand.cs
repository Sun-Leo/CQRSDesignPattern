using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands
{
    public class CreateCategoryCommand: IRequest
    {
        public string CategoryName { get; set; }

    }
}
