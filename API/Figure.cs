using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace API
{
    public class Figure
    {
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public Color c { get; set; }
        public int lw { get; set; }
        public string type { get; set; }
        public Figure()
        {
        }

        public Figure(int x, int y, int w, int h, string c, int lw, string type)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.c = Color.FromName(c);
            this.lw = lw;
            this.type = type;
        }

        public void paint(Graphics g)
        {
            Pen p = new Pen(c, lw);
            if (type.Equals("Rect"))
            {
                g.DrawRectangle(p, new Rectangle(x, y, w, h));
            }
            else if (type.Equals("Ellipse"))
            {
                g.DrawEllipse(p, new Rectangle(x, y, w, h));
            }
            else if (type.Equals("RRect"))
            {
                int d = (int)(0.5 * Math.Min(w, h));
                g.DrawArc(p, x, y, d, d, 180, 90);
                g.DrawArc(p, x + w - d, y + h - d, d, d, 0, 90);
                g.DrawArc(p, x, y + h - d, d, d, 90, 90);
                g.DrawArc(p, x + w - d, y, d, d, 270, 90);
                g.DrawLine(p, x + d / 2, y, x + w - d / 2, y);
                g.DrawLine(p, x, y + d / 2, x, y + h - d / 2);
                g.DrawLine(p, x + w, y + d / 2, x + w, y + h - d / 2);
                g.DrawLine(p, x + d / 2, y + h, x + w - d / 2, y + h);
            }
        }

        public override bool Equals(Object ob)
        {
            return (x == ((Figure)ob).x) && (y == ((Figure)ob).y) && (w == ((Figure)ob).w) &&
                   (h == ((Figure)ob).h) && (c.Name.Equals(((Figure)ob).c.Name)) &&
                   (lw == ((Figure)ob).lw) && (type.Equals(((Figure)ob).type));
        }

        public override int GetHashCode()
        {
            return x * y;
        }
    }
}
