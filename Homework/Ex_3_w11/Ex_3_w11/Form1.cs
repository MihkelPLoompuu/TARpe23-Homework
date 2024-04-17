using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_3_w11
{
    public partial class Form1 : Form
    {
        private bool loop;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loop = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loop = true;
            while (loop)
            {
                label1.Left -= -300;
                Thread.Sleep(400);
                label1.Top -= -100;
                Thread.Sleep(400);
                label1.Left = 215;
                Thread.Sleep(400);
                label1.Top = 215;
                Thread.Sleep(400);
                Application.DoEvents();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loop = false;
            timer1.Stop();//teeb ringi ära ja siis peadub.
        }
    }
}
