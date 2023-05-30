using Section14_Udemy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Learning_Classes.Using_List_Class;
using Learning_Classes.Using_Random_Class;
using Learning_Classes.Using_Timer_Class;
using Learning_Classes.Calculator;

namespace Learning_Classes
{
    public partial class SelectScreen : Form
    {
        public SelectScreen()
        {
            InitializeComponent();
        }

        private void btnClassObject_Click(object sender, EventArgs e)
        {
            ClassesObjects frm1 = new ClassesObjects();
            frm1.ShowDialog();
        }

        private void btnUsingListClass_Click(object sender, EventArgs e)
        {
            UsingListClass frm2 = new UsingListClass();
            frm2.ShowDialog();
        }

        private void btnUsingRandomClass_Click(object sender, EventArgs e)
        {
            UsingRandom frm3 = new UsingRandom();
            frm3.ShowDialog();
        }

        private void btnUsingTimerClass_Click(object sender, EventArgs e)
        {
            TimerClass frm4 = new TimerClass();
            frm4.ShowDialog();
        }

        private void btnUsingMathClass_Click(object sender, EventArgs e)
        {
            Form1 frm5 = new Form1();
            frm5.ShowDialog();
        }
    }
}
