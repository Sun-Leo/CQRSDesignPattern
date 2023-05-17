using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetEmployeeByIDQueryHandler
    {
        private readonly Context _context;

        public GetEmployeeByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetEmployeeByIDQueryResult Handle(GetEmployeeByIDQuery query)
        {
            var value = _context.Employees.Find(query.Id);
            return new GetEmployeeByIDQueryResult
            {
                EmployeeCity = value.EmployeeCity,
                EmployeeID = value.EmployeeID,
                EmployeeName = value.EmployeeName,
                EmployeeSurname = value.EmployeeSurname
            };
        }
    }
}
