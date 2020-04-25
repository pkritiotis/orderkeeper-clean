using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orderkeeper.Core.Customers;

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
    }
}
