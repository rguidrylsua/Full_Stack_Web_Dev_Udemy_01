using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section15_Udemy.Partial_ve_Sealed_Class
{
    public partial class PartialveSealedForm : Form
    {
        public PartialveSealedForm()
        {
            InitializeComponent();
        }
        public partial class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        public partial class Employee
        {
            public void SetValues()
            {
                Name = "Charles";
                EmployeeId = 1;
                Salary = 5000;
            }
        }
        private void PartialveSealedForm_Load(object sender, EventArgs e)
        {

        }

        //Sealed classes cannot be inhereted so

        public sealed class SealedClass
        {

        }

        /*
        public class newClass : SealedClass
        {
            
        }
        The above won't work */
        private void btnShow_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.SetValues();
            textBox1.Text += emp.EmployeeId + Environment.NewLine;
            textBox1.Text += emp.Name + Environment.NewLine;
            textBox1.Text += emp.Salary + Environment.NewLine;
        }
    }
}
