using AutoMapper;
using Orderkeeper.Core.Common;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Customers
{
    public class NewCustomerDto : MapFrom<Customer>
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Fax { get; set; }
    }
}
