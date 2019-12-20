using System;  
using System.ComponentModel.DataAnnotations;  
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeMVC.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int EmpID { get; set; }
        [ForeignKey("EmpID")]
        public virtual Employee Employee { get; set; }
    }
}