using System.Collections.Generic;
using Udemy_NETmosh_vidly.Models;

namespace Udemy_NETmosh_vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}