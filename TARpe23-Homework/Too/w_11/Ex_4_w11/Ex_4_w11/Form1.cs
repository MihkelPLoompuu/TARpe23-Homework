using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ex_4_w11
{
    public partial class Form1 : Form
    {
        private int totalSeconds;
        private string timer;
        public Form1()
        {
            InitializeComponent();
            pictureBox1_Click();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Time(textBox1.Text, out totalSeconds))
            {
                textBox1.ForeColor = Color.Black;

                timer1.Start();
            }
            else
            {
                MessageBox.Show("Please enter time in mm:ss format");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private bool Time(string input, out int seconds)
        {
            seconds =0;
            string[] timeParts = input.Split(':');

            if (!int.TryParse(timeParts[0], out int minutes) || !int.TryParse(timeParts[1], out int secs))
                return false;

            if (minutes < 0 || secs < 0 || secs > 59)
                return false;

            seconds= minutes * 60 + secs;
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalSeconds --;

            if (totalSeconds < 0)
            {
                timer1.Stop();

                textBox1.ForeColor =Color.Red;
                textBox1.Text = "00:00";
            }

            else
            {
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds % 60;
                textBox1.Text =$"{minutes:00}:{seconds:00}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00:00";
        }

        private void pictureBox1_Click()
        {
            pictureBox1.Image = Image.FromFile("C:/Users/mihke/OneDrive/Desktop/TARpe23/Homework/Ex_4_w11/Ex_4_w11/bin/Debug/K.png");
        }
    }
}
