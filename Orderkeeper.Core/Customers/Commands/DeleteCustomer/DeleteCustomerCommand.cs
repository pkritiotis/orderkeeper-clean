using MediatR;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest
    {
        public Guid customerId { get; set; }
    }
}
