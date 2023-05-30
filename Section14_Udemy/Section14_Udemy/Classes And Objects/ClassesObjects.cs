using Learning_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section14_Udemy
{
    public partial class ClassesObjects : Form
    {
        public ClassesObjects()
        {
            InitializeComponent();
        }

        Employee personDetail = new Employee();

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            
            personDetail.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            personDetail.Name = txtName.Text;
            personDetail.age = Convert.ToInt32(txtAge.Text);
            MessageBox.Show("All data received.");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            personDetail.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            personDetail.Name = txtName.Text;
            personDetail.age = Convert.ToInt32(txtAge.Text);
            SendClassObject frm = new SendClassObject();
            frm.personelDetail = personDetail;
            frm.ShowDialog();
        }
    }
}
