using System;  
using System.ComponentModel.DataAnnotations;  
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeMVC.Models
{
    public class Employee
    {   
        [Key]
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }

        public virtual Address Addresses { get; set; }
    }
}