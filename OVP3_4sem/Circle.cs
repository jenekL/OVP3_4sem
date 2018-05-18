using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OVP3_4sem
{
    class Circle
    {
        private int x, y, r;

        public Circle(int x, int y, int r, Graphics g)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        //public void Draw(int x, int y, int r, Graphics g)
        //{
        //    Pen pen = new Pen(Color.Blue);
        //    g.DrawEllipse(pen, x, y, r, r);
        //    pen.Dispose();
        //}
        //public void Draw(Graphics g)
        //{
        //    Pen pen = new Pen(Color.Blue);
        //    g.DrawEllipse(pen, x, y, r, r);
        //    pen.Dispose();
        //}
        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public int R
        {
            set
            {
                r = value;
            }
            get
            {
                return r;
            }
        }
    }
}
