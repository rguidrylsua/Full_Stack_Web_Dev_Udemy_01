using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int firstnumber = 0, lastnumber = 0;
        int divisibleterm = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("9");
            cmbDivisibleTerm.Items.Add("10");
            rbBlack.Checked = true;
        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleterm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
        }


        int controlNumber = 1;

        private void txtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Checked Changed Events for Radio Buttons
        #region Radio Buttons
        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
            {
                rbRed.Checked = false;
                rbGreen.Checked = false;
                rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                rbBlack.Checked = false;
                rbGreen.Checked = false;
                rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                rbRed.Checked = false;
                rbBlack.Checked = false;
                rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Green;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbRed.Checked = false;
                rbGreen.Checked = false;
                rbBlack.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;
            }
        }
        #endregion Radio Buttons

        //Control Font Style
        #region Font Style
        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Bold);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Italic);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }
        #endregion Font Style

        private void btnCount_Click(object sender, EventArgs e)
        {
            string divisibleNumber = "";
            if (txtStartFrom.Text.Trim() == "" || txtTo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the start and end numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the divisible term", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                firstnumber = Convert.ToInt32(txtStartFrom.Text);
                lastnumber = Convert.ToInt32(txtTo.Text);
                for (int i = firstnumber; i < lastnumber; i++)
                {
                    if (i % divisibleterm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                        {
                            divisibleNumber += Environment.NewLine;
                            //divisibleNumber += "\n";
                        }
                        controlNumber++;
                    }
                }
                txtDivisibleNumbers.Text = divisibleNumber;
            }
        }
    }
}
