using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Classes.Using_List_Class
{
    public partial class UsingListClass : Form
    {
        public UsingListClass()
        {
            InitializeComponent();
        }

        List<PersonEmployee> employeeList = new List<PersonEmployee>();
        public List<PersonEmployee>  fillList()
        {
            employeeList.Clear();
            PersonEmployee employee1 = new PersonEmployee();
            employee1.ID = 1;
            employee1.Name = "John";
            employee1.Surname = "Doe";
            employeeList.Add(employee1);
            PersonEmployee employee2 = new PersonEmployee();
            employee2.ID = 2;
            employee2.Name = "Jane";
            employee2.Surname = "Doe";
            employeeList.Add(employee2);
            PersonEmployee employee3 = new PersonEmployee();
            employee3.ID = 3;
            employee3.Name = "Jack";
            employee3.Surname = "Dames";
            employeeList.Add(employee3);
            return employeeList;
        }

        List<Days> comboList = new List<Days>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Days day1 = new Days();
            day1.ID = 1;
            day1.textvalue = "Sunday";
            comboList.Add(day1);
            Days day2 = new Days();
            day2.ID = 2;
            day2.textvalue = "Monday";
            comboList.Add(day2);
            Days day3 = new Days();
            day3.ID = 3;
            day3.textvalue = "Tuesday";
            comboList.Add(day3);
            Days day4 = new Days();
            day4.ID = 4;
            day4.textvalue = "Wednesday";
            comboList.Add(day4);
            Days day5 = new Days();
            day5.ID = 5;
            day5.textvalue = "Thursday";
            comboList.Add(day5);
            Days day6 = new Days();
            day6.ID = 6;
            day6.textvalue = "Friday";
            comboList.Add(day6);
            Days day7 = new Days();
            comboList.Add(new Days() { ID = 7, textvalue = "Saturday" });

            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textvalue";

            daylist.DataSource = comboList;

        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();
            foreach (var item in employeeList)
            {
                txtNumber.Text += item.ID + " " + item.Name + " " + item.Surname + Environment.NewLine;
            }
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
