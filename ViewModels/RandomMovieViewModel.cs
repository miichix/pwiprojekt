using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PwI_MVC.Models;

namespace PwI_MVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}