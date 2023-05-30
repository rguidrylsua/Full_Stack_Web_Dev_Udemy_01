using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Section15_Udemy.Encapsulation;
using Section15_Udemy.Static_Using;
using Section15_Udemy.Inheritance;

namespace Section15_Udemy
{
    public partial class SelectionScreen : Form
    {
        public SelectionScreen()
        {
            InitializeComponent();
        }

        private void btnEncapsulation_Click(object sender, EventArgs e)
        {
            EncapsulationForm encapsulationForm = new EncapsulationForm();
            encapsulationForm.ShowDialog();
        }

        private void btnStaticUsing_Click(object sender, EventArgs e)
        {
            StaticUsing staticUsingForm = new StaticUsing();
            staticUsingForm.ShowDialog();
        }

        private void btnInheritance_Click(object sender, EventArgs e)
        {
            InheritanceForm inheritanceForm = new InheritanceForm();
            inheritanceForm.ShowDialog();
        }
    }
}
