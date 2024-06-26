﻿using B2GNowCoding.Core.Employee.Handler;
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
        [HttpGet("search")]
        public async Task<EmployeesSearchResponse> GetEmployeesByPhoneNumber(string search)
        {
            var response = await _mediator.Send(new GetEmployeesSearchQuery() { Search = search});
            return response;
        }
    }
}
