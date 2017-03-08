﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public Contact Contact { get; set; }

        public string City { get; set; }

        public string Role { get; set; }
    }
}