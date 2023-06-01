using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15_Udemy.Polymorphism
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double EmployeeSalary { get; set; } 
        public void SetValues(int id)
        {
            EmployeeID = id;
        }
        public void SetValues(int id, string EmployeeName)
        {
            EmployeeID = id;
            Name = EmployeeName;
        }
        public void SetValues(int id, string EmployeeName, double salary)
        {
            EmployeeID = id;
            Name = EmployeeName;
            EmployeeSalary = salary;
        }
    }
}
