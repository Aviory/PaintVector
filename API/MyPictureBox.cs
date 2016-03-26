using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API
{
    public class MyPictureBox : PictureBox
    {
        private List<Figure> figs = new List<Figure>();

        public XData xd = null;

        Graphics g = null;
        int x = 0;
        int y = 0;
        bool isDraw = false;
       
        Figure figToMove = null;

        public MyPictureBox(int w, int h)
        {
            this.Width = w;
            this.Height = h;
            this.BackColor = Color.White;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Bitmap b = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(b);
            this.Image = b;

            g.Clear(Color.White);
            MouseDown += new MouseEventHandler(MyPictureBox_MouseDown);
            MouseUp += new MouseEventHandler(MyPictureBox_MouseUp);
            MouseMove += new MouseEventHandler(MyPictureBox_MouseMove);
        }

        private void MyPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (xd.state.Equals("Move") && figToMove != null)
            {
                figToMove.x += e.Location.X - x;
                figToMove.y += e.Location.Y - y;
                x = e.Location.X;
                y = e.Location.Y;
                paint();
            }
        }

        private void MyPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (!xd.state.Equals("Move") && isDraw)
            {
                figs.Add(new Figure(x, y, e.Location.X - x, e.Location.Y - y, xd.c, xd.lw, xd.state));
            }
            paint();
            isDraw = false;
            figToMove = null;
        }

        private void MyPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDraw = true;
            x = e.Location.X;
            y = e.Location.Y;
            if (xd.state.Equals("Move"))
            {
                foreach (Figure f in figs)
                {
                    if (x >= f.x && x <= f.x + f.w && y >= f.y && y <= f.y + f.h)
                    {
                        figToMove = f;
                        break;
                    }
                }
            }
        }

        public List<Figure> getMemento()
        {
            return figs;
        }

        public void setMemento(List<Figure> figs)
        {
            clear();
            this.figs.AddRange(figs);
            paint();
        }


        private void paint()
        {
            foreach (Figure f in figs)
            {
                f.paint(g);
            }
            Refresh();
        }

        public void clear()
        {
            figs.Clear();
            g.Clear(Color.White);
            Refresh();
        }
    }
}
