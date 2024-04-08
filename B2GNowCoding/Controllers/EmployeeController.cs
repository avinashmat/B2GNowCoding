using B2GNowCoding.Core.Employee.Handler;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace B2GNowCoding.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private IMediator _mediator;
        public EmployeeController(IMediator mediator) { 
        _mediator = mediator;
        } 
        [HttpGet]
        public async Task<EmployeesResponse> GetEmployees() 
        {
            var response = await _mediator.Send(new GetEmployeesQuery());
            return response;
        }
        //[HttpGet]
        //public async Task<IEnumerable<EmployeesResponse>> GetEmployeesByPhoneNumber(string search)
        //{
        //    var response = await _mediator.Send(new GetEmployeesQuery());
        //    return response;
        //}
    }
}
