using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Classes
{
    public partial class SendClassObject : Form
    {
        public SendClassObject()
        {
            InitializeComponent();
        }

        public Employee personelDetail = new Employee();

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = personelDetail.EmployeeID.ToString();
            textBox2.Text = personelDetail.Name;
            textBox3.Text = personelDetail.age.ToString();
        }
    }
}
