﻿using System.Collections.Generic;

namespace Udemy_NETmosh_vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}