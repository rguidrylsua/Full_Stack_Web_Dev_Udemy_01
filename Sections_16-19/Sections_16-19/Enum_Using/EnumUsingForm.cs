using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sections_16_19.Enum_Using
{
    public partial class EnumUsingForm : Form
    {
        public EnumUsingForm()
        {
            InitializeComponent();
        }
        enum colors { Red, Blue, White, Black, Yellow=7, Purple, Brown, Orange };
        private void EnumUsingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string text = "Red: " + (int)colors.Red + Environment.NewLine;
            text += "Blue: " + (int)colors.Blue + Environment.NewLine;
            text += "White: " + (int)colors.White + Environment.NewLine;
            text += "Black: " + (int)colors.Black + Environment.NewLine;
            text += "Yellow: " + (int)colors.Yellow + Environment.NewLine;
            text += "Purple: " + (int)colors.Purple + Environment.NewLine;
            text += "Brown: " + (int)colors.Brown + Environment.NewLine;
            text += "Orange: " + (int)colors.Orange + Environment.NewLine;
            textBox1.Text = text;

        }
    }
}
