using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section15_Udemy.Polymorphism
{
    public partial class PolymorphismForm : Form
    {
        public PolymorphismForm()
        {
            InitializeComponent();
        }

        private void btn1Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1);
            string messagetext = teacher.GetValues();
            textBox1.Text = messagetext;
        }

        private void btn2Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1,"Charles");
            string messagetext = teacher.GetValues();
            textBox1.Text = messagetext;
        }

        private void btn3Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Charles",2000);
            string messagetext = teacher.GetValues();
            textBox1.Text = messagetext;
        }

        private void btn4Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Charles", 2000, "Teacher");
            string messagetext = teacher.GetValues();
            textBox1.Text = messagetext;
        }

        private void btnVirtual_Click(object sender, EventArgs e)
        {
            Employee2 employee = new Employee2();
            string messagetext = employee.SetValues(1, "Charles", 2000);
            textBox1.Text = messagetext;
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            Teacher2 employee = new Teacher2();
            string messagetext = employee.SetValues(1, "Charles", 2000);
            textBox1.Text = messagetext;
        }
    }
}
