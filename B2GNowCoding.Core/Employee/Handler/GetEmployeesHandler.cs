using B2GNowCoding.Db.Implementation;
using MediatR;
using B2GNowCoding.Db.Interface;
using AutoMapper;
using B2GNowCoding.Db;
namespace B2GNowCoding.Core.Employee.Handler
{
    public class GetEmployeesHandler : IRequestHandler<GetEmployeesQuery, EmployeesResponse>
    {
        private IGetEmployees _getEmployees;
     
        public GetEmployeesHandler(IGetEmployees getEmployees) {
            _getEmployees = getEmployees;
        }
        public Task<EmployeesResponse> Handle(GetEmployeesQuery query, CancellationToken token)
        {
            var employees = _getEmployees.GetAll();
            return Task.FromResult(new EmployeesResponse() {Employee = employees});
        }
    }
    public class GetEmployeesQuery : IRequest<EmployeesResponse>
    {

    }
    public class EmployeesResponse
    {
        public IEnumerable<Db.Employee> Employee;

    }
}
