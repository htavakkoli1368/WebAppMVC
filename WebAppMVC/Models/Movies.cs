﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movies> ListMovie  { get; set; }
         
    }
}
