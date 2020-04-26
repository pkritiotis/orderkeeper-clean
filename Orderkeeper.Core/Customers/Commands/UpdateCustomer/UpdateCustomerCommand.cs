using MediatR;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest
    {
        public UpdatedCustomerDto UpdatedCustomer { get; set; }
    }
}
