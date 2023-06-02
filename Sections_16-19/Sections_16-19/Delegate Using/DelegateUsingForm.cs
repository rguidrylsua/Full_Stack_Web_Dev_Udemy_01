using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sections_16_19.Delegate_Using
{
    public partial class DelegateUsingForm : Form
    {
        public DelegateUsingForm()
        {
            InitializeComponent();
        }

        public delegate void fillTextBox(int x);
        string textvalue = "";
        public void FillMathNote(int ExamNote)
        {
            textvalue += "Your Math Note is: " + ExamNote + Environment.NewLine;
        }

        public void FillChemistryNote(int ExamNote)
        {
            textvalue += "Your Chemistry Note is: " + ExamNote + Environment.NewLine;
        }

        public void ShowinTextBox()
        {
            textBox1.Text = textvalue;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //fillTextBox fillText = FillMathNote;
            fillTextBox fillText = new fillTextBox(FillMathNote);
            fillText += FillChemistryNote;
            fillText(80);
            fillText -= FillMathNote;
            fillText(60);
            ShowinTextBox();
        }

        private void DelegateUsingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
