using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sections_16_19.Path_Class
{
    public partial class PathClassForm : Form
    {
        public PathClassForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string ourfile = @"C:\newfolder\temp\forest.jpg";
            textBox1.Text += Path.GetDirectoryName(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetExtension(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetFileName(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetFileNameWithoutExtension(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetPathRoot(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetFullPath(ourfile) + Environment.NewLine;


        }
    }
}
