﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section15_Udemy.Inheritance
{
    public partial class InheritanceForm : Form
    {
        public InheritanceForm()
        {
            InitializeComponent();
        }

        //Human -> Employee -> Teacher

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Setvalues();
            teacher.SetValues2();
            teacher.FindSalary();
            string allvalues = "";
            allvalues += teacher.Name + Environment.NewLine;
            allvalues += teacher.Gender + Environment.NewLine;
            allvalues += teacher.Age + Environment.NewLine;
            allvalues += teacher.Branch + Environment.NewLine;
            allvalues += teacher.Salary + Environment.NewLine;
            textBox1.Text = allvalues;
        }
    }
}
