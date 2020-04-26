using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orderkeeper.Core.Customers;
using Orderkeeper.Core.Customers.Commands.CreateCustomer;
using Orderkeeper.Core.Customers.Commands.DeleteCustomer;
using Orderkeeper.Core.Customers.Commands.UpdateCustomer;

namespace Orderkeeper.Api.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> Get()
        {
            return await Mediator.Send(new GetCustomersQuery());
        }

        [HttpGet("{Id}")]
        public async Task<GetCustomerResult> Get(Guid Id)
        {
            return await Mediator.Send(new GetCustomerQuery { Id = Id });
        }

        [HttpDelete("{Id}")]
        public async Task Delete(Guid Id)
        {
            await Mediator.Send(new DeleteCustomerCommand { customerId = Id });
        }

        [HttpPut("{Id}")]
        public async Task Delete(Guid Id, UpdatedCustomerDto updatedCustomer)
        {
            await Mediator.Send(new UpdateCustomerCommand { UpdatedCustomer = updatedCustomer});
        }

        [HttpPost]
        public async Task<Guid> Create( NewCustomerDto newCustomer)
        {
            return await Mediator.Send(new CreateCustomerCommand { NewCustomer = newCustomer });
        }
    }
}
