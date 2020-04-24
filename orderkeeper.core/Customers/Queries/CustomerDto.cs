using orderkeeper.core.Common;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace orderkeeper.core.Customers
{
    public class CustomerDto : MapFrom<Customer>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Fax { get; set; }
    }
}
