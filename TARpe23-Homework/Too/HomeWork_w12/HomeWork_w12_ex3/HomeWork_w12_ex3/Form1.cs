using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_w12_ex3
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int x, y;
        private bool movingDown = true;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            timer1.Start();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100; 
            timer.Tick += timer1_Tick;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.GreenYellow, 10); 
            e.Graphics.DrawLine(pen, x, y, x, y + 10); 
            pen.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (movingDown)
            {
                y += 10;
                if (y >= this.ClientSize.Height)
                {
                    movingDown = false;
                    x += 20; 
                }
            }
            else
            {
                y -= 10;
                if (y <= 0)
                {
                    movingDown = true;
                    x += 20; 
                }
            }

            this.Invalidate(); 
        }
    }
}
