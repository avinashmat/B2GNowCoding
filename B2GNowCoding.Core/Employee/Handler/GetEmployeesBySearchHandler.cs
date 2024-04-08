using B2GNowCoding.Db.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2GNowCoding.Core.Employee.Handler
{
    public  class GetEmployeesBySearchHandler : IRequestHandler<GetEmployeesSearchQuery, EmployeesSearchResponse>
    {
        private IGetEmployees _getEmployees;

        public GetEmployeesBySearchHandler(IGetEmployees getEmployees)
        {
            _getEmployees = getEmployees;
        }
        public Task<EmployeesSearchResponse> Handle(GetEmployeesSearchQuery query, CancellationToken token)
        {
            var employees = _getEmployees.GetEmployeeBySearch(query.Search);
            return Task.FromResult(new EmployeesSearchResponse() { Employee = employees });
        }
    }
    public class GetEmployeesSearchQuery : IRequest<EmployeesSearchResponse>
    {
        public string Search { get; set; }
    }
    public class EmployeesSearchResponse
    {
        public IEnumerable<Db.Employee> Employee;

    }
}
