using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class UpdateEmployeeCommandHandler
    {
        private readonly Context _context;

        public UpdateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateEmployeeCommand command)
        {
            var value = _context.Employees.Find(command.EmployeeID);
            value.EmployeeName = command.EmployeeName;
            value.EmployeeSurname = command.EmployeeSurname;
            value.EmployeeSalary = command.EmployeeSalary;
            value.EmployeeAge = command.EmployeeAge;
            value.EmployeeCity = command.EmployeeCity;
            value.EmployeeTitle = command.EmployeeTitle;
            _context.SaveChanges();
        }
    }
}
