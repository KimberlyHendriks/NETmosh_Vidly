using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Udemy_NETmosh_vidly.Models;

namespace Udemy_NETmosh_vidly.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customers { get; set; }
        public List<Customer> Customer { get; set; }
    }
}