using MediatorAkademiPlusPostgre.DAL;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands
{
    public class UpdateProductCommand: IRequest
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
