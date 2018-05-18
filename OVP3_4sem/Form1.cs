using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVP3_4sem
{
    public partial class Form1 : Form
    {
        Graphics gr;
        CirclesDraw CD;
        int h = 10;
        Random r;
        bool []b;
        bool b1;
        
        public Form1()
        {
            InitializeComponent();
            gr = pictureBox1.CreateGraphics();
            CD = new CirclesDraw();
            r = new Random();
            trackBar1.Maximum = 250;
            trackBar1.TickFrequency = 15;
            b = new bool[20];

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue);

            //g.DrawEllipse(pen, 50, 50, 100, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CD.CreateCircle(CD.X, h, 20, gr);
            //timer1.Enabled = true;
            //timer1.Start();
            timer1.Interval = 100;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // foreach(Circle element in CD)
            gr.Clear(Color.White);
            for (int i = 0; i < CD.KolCirc; i++)
            {
                if (pictureBox1.ClientSize.Width < CD.X)
                {
                    b1 = true;
                }
                else if (CD.X < 0)
                {
                    b1 = false;
                }
                if (b1)
                {
                    CD.X -= 10;
                   // CD[i].X -= 10;
                }
                else
                {
                    CD.X += 10;
                   // CD[i].X += 10;
                }
               // CD[i].R = r.Next(10, 50);

                //CD[i].Draw(gr);
                CD.DrawAll(gr);

                //if (CD.KolCirc > 19)
                //{
                //    button1.Visible = false;
                //}
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            h = trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //pictureBox1.Image.Dispose();
        }

        private void StartStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
