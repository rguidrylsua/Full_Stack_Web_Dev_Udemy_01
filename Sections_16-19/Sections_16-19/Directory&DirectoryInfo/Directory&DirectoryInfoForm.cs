using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    // For Directory and DirectoryInfo

namespace Sections_16_19.Directory_DirectoryInfo
{
    public partial class Directory_DirectoryInfoForm : Form
    {
        public Directory_DirectoryInfoForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            DirectoryInfo dr=new DirectoryInfo("folder2");
            string accesstime = dr.CreationTime.ToString();
            MessageBox.Show(accesstime);
            
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Directory.Move("temp", @"C:\newfolder\temp");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp");
        }
    }
}
