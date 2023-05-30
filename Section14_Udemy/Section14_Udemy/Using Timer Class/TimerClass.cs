using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Classes.Using_Timer_Class
{
    public partial class TimerClass : Form
    {
        public TimerClass()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                counter = 60;
            }
            timer1.Start(); // Starts the timer
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Stops the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = counter;
            counter--;
            label1.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up!");
            }
            if(counter % 2 == 1)
                btnMessage.BackColor = Color.Red;
            else
                btnMessage.BackColor = Color.Green;
        }

        int counter = 60;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = 50.ToString();
        }
    }
}
