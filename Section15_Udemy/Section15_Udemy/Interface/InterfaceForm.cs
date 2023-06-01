using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section15_Udemy.Interface
{
    public partial class InterfaceForm : Form
    {
        public InterfaceForm()
        {
            InitializeComponent();
        }

        interface Computer
        {
            void GetDesktops();
            void GetLaptops();
        }

        class DellComputers: Computer, DellComputer
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Mark { get; set; }
            public void GetDesktops()
            {
                Name = "Desktop1";
                Price = 2000;
            }
            public void GetLaptops()
            {
                Name = "Laptop1";
                Price = 1500;
            }

            public void GetMark()
            {
                Mark = "Dell";
            }
        }

        private void InterfaceForm_Load(object sender, EventArgs e)
        {

        }
        interface DellComputer
        {
            void GetMark();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            DellComputers dell = new DellComputers();
            dell.GetLaptops();
            dell.GetMark();
            string textvalue = "Name: " + dell.Name + Environment.NewLine;
            textvalue += "Price: " + dell.Price + Environment.NewLine;
            textvalue += "Mark: " + dell.Mark + Environment.NewLine;
            textBox1.Text = textvalue;
        }
    }
}
