using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section15_Udemy.Encapsulation
{
    public partial class EncapsulationForm : Form
    {
        public EncapsulationForm()
        {
            InitializeComponent();
        }

        private void Encapsulation_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.EmployeeName = txtEmployeeName.Text;
            employeeDetails.EmployeeAge = Convert.ToInt32(txtEmployeeAge.Text);
            employeeDetails.EmployeePosition = txtEmployeePosition.Text;

            FrmEmployeeDetail frm = new FrmEmployeeDetail();
            frm.label2.Text = employeeDetails.EmployeeName;
            frm.label3.Text = employeeDetails.EmployeeAge.ToString();
            frm.label4.Text = employeeDetails.EmployeePosition;
            frm.ShowDialog();
        }
    }
}
