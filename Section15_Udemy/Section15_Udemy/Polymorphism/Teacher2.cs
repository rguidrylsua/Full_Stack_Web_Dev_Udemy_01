using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15_Udemy.Polymorphism
{
    public class Teacher2 : Employee2
    {

        override public string SetValues(int id, string EmployeeName, double salary)
        {
            EmployeeID = id;
            Name = EmployeeName;
            EmployeeSalary = salary;
            EmployeePosition = "teacher";

            string text = "Employee ID: " + EmployeeID + Environment.NewLine;
            text += "Employee Name: " + Name + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            text += "Employee Position: " + EmployeePosition + Environment.NewLine;
            return text;
        }
    }
}
