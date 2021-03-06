﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Orderkeeper.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Fax { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
