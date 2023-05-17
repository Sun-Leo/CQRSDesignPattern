using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands
{
    public class UpdateCategoryCommand: IRequest
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
