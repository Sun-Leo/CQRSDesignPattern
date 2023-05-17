using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class CreateEmployeeCommandHandler
    {
        private readonly Context _context;

        public CreateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateEmployeeCommand commandHandler)
        {
            _context.Employees.Add(new Employee
            {
                EmployeeAge = commandHandler.EmployeeAge,
                EmployeeCity = commandHandler.EmployeeCity,
                EmployeeName = commandHandler.EmployeeName,
                EmployeeSalary = commandHandler.EmployeeSalary,
                EmployeeSurname = commandHandler.EmployeeSurname,
                EmployeeTitle = commandHandler.EmployeeTitle
            });
            _context.SaveChanges();
                
        }
    }
}
