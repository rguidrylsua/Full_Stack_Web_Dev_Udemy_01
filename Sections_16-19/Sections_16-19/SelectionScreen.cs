using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sections_16_19.Enum_Using;
using Sections_16_19.Delegate_Using;
using Sections_16_19.Exception_Handling;
using Sections_16_19.Directory_DirectoryInfo;
using Sections_16_19.File_FileInfo;
using Sections_16_19.Path_Class;

namespace Sections_16_19
{
    public partial class SelectionScreen : Form
    {
        public SelectionScreen()
        {
            InitializeComponent();
        }

        private void btnEnumUsing_Click(object sender, EventArgs e)
        {
            EnumUsingForm enumUsingForm = new EnumUsingForm();
            enumUsingForm.ShowDialog();
        }

        private void btnDelegateUsing_Click(object sender, EventArgs e)
        {
            DelegateUsingForm delegateUsingForm = new DelegateUsingForm();
            delegateUsingForm.ShowDialog();
        }

        private void btnExceptionHandling_Click(object sender, EventArgs e)
        {
            ExceptionHandlingForm exceptionHandlingForm = new ExceptionHandlingForm();
            exceptionHandlingForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory_DirectoryInfoForm directory_DirectoryInfoForm = new Directory_DirectoryInfoForm();
            directory_DirectoryInfoForm.ShowDialog();
        }

        private void btnFileAndFileInfo_Click(object sender, EventArgs e)
        {
            FileAndFileInfoForm fileAndFileInfoForm = new FileAndFileInfoForm();
            fileAndFileInfoForm.ShowDialog();
        }

        private void btnPathClass_Click(object sender, EventArgs e)
        {
            PathClassForm pathClassForm = new PathClassForm();
            pathClassForm.ShowDialog();
        }
    }
}
