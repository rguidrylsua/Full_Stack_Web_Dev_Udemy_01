using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section15_Udemy.Static_Using
{
    class Student
    {
        public static int StudentNumber { get; set; }

        public static void getAddNote()
        {
            MessageBox.Show("Note added");
        }
    }
}
