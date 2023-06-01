﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15_Udemy.Polymorphism
{
    public class Teacher : Employee
    {
        public string EmployeePosition { get; set; }
        public void SetValues(int id, string EmployeeName, double salary, string position)
        {
            EmployeeID = id;
            Name = EmployeeName;
            EmployeeSalary = salary;
            EmployeePosition = position;
        }
        public string GetValues()
        {
            string text = "Employee ID: " + EmployeeID + Environment.NewLine;
            text += "Employee Name: " + Name + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            text += "Employee Position: " + EmployeePosition;
            return text;
        }
    }
}
