﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeGest
{
  
   public class Employee
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
    }
}
