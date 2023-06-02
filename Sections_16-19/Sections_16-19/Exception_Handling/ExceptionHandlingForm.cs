using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sections_16_19.Exception_Handling
{
    public partial class ExceptionHandlingForm : Form
    {
        public ExceptionHandlingForm()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(txtFirstNumber.Text) / Convert.ToInt32(txtSecondNumber.Text);
            }
            catch (DivideByZeroException ex)
            {

                throw new Exception("You can't divide by zero");
            }
            catch (Exception ex)
            {
                throw new Exception("Please use only numbers");
            }
            finally
            {
                MessageBox.Show("Program was finished");
            }
            
        }
    }
}
