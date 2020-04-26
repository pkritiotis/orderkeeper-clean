using MediatR;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<Guid>
    {
        public NewCustomerDto NewCustomer { get; set; }
    }
}
