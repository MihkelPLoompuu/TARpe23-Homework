using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_1_w11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1_Click();
            timer1.Start();
        }

        private void pictureBox1_Click()
        {           
            pictureBox1.Image = Image.FromFile("C:/Users/opilane/source/repos/ex_1_w11/ex_1_w11/bin/Debug/K.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime StartDate = System.DateTime.Now;
            DateTime EndDate = new DateTime(2025, 02, 27, 5, 10, 10);
            TimeSpan TimeDifference = EndDate - StartDate;

            label1.Text = TimeDifference.ToString();
        }
    }
}
