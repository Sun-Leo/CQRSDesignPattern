using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetEmployeeQueryHandler
    {
        private readonly Context _context;

        public GetEmployeeQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetEmployeeQueryResult> Handle()
        {
            var value= _context.Employees.Select(x=> new GetEmployeeQueryResult
            {
                EmployeeAge = x.EmployeeAge,
                EmployeeName = x.EmployeeName,
                EmployeeSurname = x.EmployeeSurname,
                EmployeeCity = x.EmployeeCity,
                EmployeeID = x.EmployeeID,
                EmployeeSalary = x.EmployeeSalary,
                EmployeeTitle = x.EmployeeTitle,
            }).ToList();
            return value;
        }
    }
}
