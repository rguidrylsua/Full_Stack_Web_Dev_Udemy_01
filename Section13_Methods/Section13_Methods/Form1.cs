using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section13_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void HideRadioButtons()
        {
            groupBox1.Visible = false;
        }

        public void ClearAllTexts()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        public void FillTextBox(string text)
        {
            textBox2.Text = text;
        }

        public void SetNumber(int age)
        {
            label1.Text = "You are " + age.ToString() + " years old.";
        }

        string GetName()
        {
            string name = "Charles";
            return name;
        }

        int Sum(int x,int y)
        {
            int result = x + y;
            return result;
        }
        #region Overloading
        string ValueControl()
        {
            string text = "";
            return text;
        }

        string ValueControl(string name)
        {
            string text = "";
            return text;
        }

        string ValueControl(string name, bool control)
        {
            string text = "";
            return text;
        }
        #endregion Overloading

        private void button1_Click(object sender, EventArgs e)
        {
            string name = ValueControl("John",true);
            MessageBox.Show(name);
        }
    }
}
