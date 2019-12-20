using EmployeeMVC.Data;
using EmployeeMVC.Models;
using System;
using System.Linq;

namespace EmployeeMVC.Data
{
    public static class DBInitializer
    {
        public static void Initialize(EmployeeContext context){
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
                new Employee{Name="Siddharth",Department="EC",Salary="40000"},
                 new Employee{Name="Devang",Department="IT",Salary="30000"},
                  new Employee{Name="Meet",Department="Computer",Salary="20000"},
                   new Employee{Name="Karan",Department="Mechanical",Salary="10000"},
            };
            foreach (Employee s in employees)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();

            var addresses = new Address[]
            {
                new Address{EmpID=1,City="Surat",State="Gujrat",Country="India"},
                new Address{EmpID=2,City="Vadodara",State="Gujrat",Country="India"},
                new Address{EmpID=3,City="Goa",State="Goa",Country="India"},
                new Address{EmpID=4,City="Bhavnagar",State="Gujrat",Country="India"},
                
            };
            foreach (Address c in addresses)
            {
                context.Addresses.Add(c);
            }
            context.SaveChanges();


        }
    }
}