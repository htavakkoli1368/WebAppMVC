using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.ViewModel
{
    public class RandomViewModel
    {
        public Movies movies { get; set; }
        public List<Customers> customers { get; set; }
    }
}
