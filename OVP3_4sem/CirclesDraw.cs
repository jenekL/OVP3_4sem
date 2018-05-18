using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OVP3_4sem
{
    class CirclesDraw
    {
        Random r;
        private Circle[] C;
        private List<Circle> Circ;
        private int kolCircles = 0;
        private int x = 10;

        public delegate void ChangeX();

        public event ChangeX Change;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
               foreach(Circle C in Circ)
                {
                    C.X = x;
                }
                x = value;

            }
        }

        public CirclesDraw()
        {
            r = new Random();
            C = new Circle[20];
            Circ = new List<Circle>();
        }
        public void CreateCircle(int x, int y, int r, Graphics gr)
        {
           // C[kolCircles++] = 
            Circle tmp = new Circle(x, y, r, gr);
            Circ.Add(tmp);
            
        }

        public void Draw(int i, Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)), 20);
            g.DrawEllipse(pen, C[i].X, C[i].Y, C[i].R, C[i].R);
        }

        public void DrawAll(Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)), 20);
            foreach (Circle C in Circ)
            {
                g.DrawEllipse(pen, X, C.Y, C.R, C.R);
            }
            for(int i = 0; i < kolCircles; i++)


            {
                g.DrawEllipse(pen, X, Circ[i].Y, Circ[i].R, Circ[i].R);
            }
        }

        public Circle this[int i]{
            get
            {
               // return C[i];
                return Circ[i];
            }
        }

        public int KolCirc
        {
            get
            {
                return kolCircles;
            }
            set
            {
                kolCircles = value;
            }
        }
    }
}
