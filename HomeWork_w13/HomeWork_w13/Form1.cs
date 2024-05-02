using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_w13
{
    public partial class Form1 : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 12;
        int score;
        int Hscore;
        int lives = 3;
        int totalcount = 0;
        private int Y = 3;
        private int X = 10;

        Random random = new Random();
        List<PictureBox> items = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            label1_Click();
            Score();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1_Click();
            if (moveLeft == true && pictureBox2.Left > 0) 
            {
                pictureBox2.Left -= speed;
            }
            if (moveRight == true && pictureBox2.Right < 530)
            {
                pictureBox2.Left += speed;
            }
            if (moveUp == true && pictureBox2.Top > 0)
            {
                pictureBox2.Top -= speed;
            }
            if (moveDown == true && pictureBox2.Top < 413)
            {
                pictureBox2.Top += speed;
            }
            foreach (PictureBox item in items.ToList()) 
            {
                if (pictureBox2.Bounds.IntersectsWith(item.Bounds))
                {
                    items.Remove(item);
                    this.Controls.Remove(item);    
                    score+= 15;
                    label2.Text = "Score:" + score;
                    totalcount++;
                    if (score > Hscore)
                    {
                        label3.Text = "High score:" + score;
                    }
                    if (totalcount > 4)
                    {
                        label1.Text = "Lives:" + (lives+= 1);
                        totalcount = 0;
                    }
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    label1.Text = "Lives:" + (lives -= 1);
                    Thread.Sleep(50);
                    pictureBox1.Location = new Point(50, 100);
                    if (lives == 0)
                    {
                        label4.Visible = true;
                        label4.Text = "Game Over";
                        label5.Visible = true;
                        Hscore = score;
                        label5.Text = "High Score " + Hscore.ToString();
                        timer1.Stop();
                        timer2.Stop();
                    }
                }
            }            
        } 
        private void MakeRandomBonusBalls() 
        {
            PictureBox newPic = new PictureBox();
            newPic.Height = 10;
            newPic.Width = 10;
            newPic.BackColor = Color.Blue;

            int x = random.Next(10, this.ClientSize.Width - newPic.Width);
            int y = random.Next(10, this.ClientSize.Height - newPic.Height);
            newPic.Location = new Point(x, y);

            items.Add(newPic);
            this.Controls.Add(newPic);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MakeRandomBonusBalls();
            label2.Text = "Score:" + (score += 10);
            if (score > Hscore)
            {
                label3.Text = "High score:" + score;
            }
        }

        private void label1_Click()
        {
            label1.Text = "Lives:" + lives;
        }

        private void Score() 
        {
            string FilePath = @"C:\Users\mihke\OneDrive\Desktop\TARpe23\Homework\HomeWork_w13\HomeWork_w13\bin\Debug\score.txt";
            if (File.Exists(FilePath))
            {
                StreamReader sr = new StreamReader(FilePath);
                label3.Text = sr.ReadToEnd();
                sr.Close();
                if (score > Hscore) 
                {
                    label3.Text = score.ToString();
                    StreamWriter sw = new StreamWriter(FilePath);
                    sw.WriteLine(label3.Text);
                    sw.Close();
                }
            }
            else 
            {
                using (StreamWriter sw = File.AppendText(FilePath)) 
                {
                    sw.Write("0");
                    sw.Close ();
                }
            }
        }

        private void pictureBox1_Click()
        {
            int currentX = pictureBox1.Location.X;
            int currentY = pictureBox1.Location.Y;

            int newX = currentX + X;
            int newY = currentY + Y;

            if (newX < 0 || newX + pictureBox1.Width > this.ClientSize.Width)
            {
                X = -X;
                newX = Math.Max(0, Math.Min(newX, this.ClientSize.Width - pictureBox1.Width));
            }
            if (newY < 0 || newY + pictureBox1.Height > this.ClientSize.Height)
            {
                Y = -Y;
                newY = Math.Max(0, Math.Min(newY, this.ClientSize.Height - pictureBox1.Height));
            }

            pictureBox1.Location = new Point(newX, newY);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen RedPen = new Pen(Color.Red, 10);
            var s = RedPen;
            int x = 15;
            int y = 15;
            int width = 10;
            int height = 10;
            e.Graphics.DrawEllipse(RedPen, x, y, width, height);
            RedPen.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) 
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
        }
    }
}
