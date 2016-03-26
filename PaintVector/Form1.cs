using API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintVector
{
    public partial class Form1 : Form
    {
        MyPictureBox pictureBox;
        XData xd = new XData();

        XCommands cmd = null;

        public Form1()
        {
            InitializeComponent();
            pictureBox = new MyPictureBox(splitContainer1.Panel2.Width, splitContainer1.Height);
            pictureBox.xd = xd;
            splitContainer1.Panel2.Controls.Add(pictureBox);
            stateTB.Text = xd.state;
            xd.c = pnlColor.BackColor.Name;
            xd.lw = widthTrB.Value;
        }

        private void stateBtn_Click(object sender, EventArgs e)
        {
            xd.state = ((Button)sender).Text;
            stateTB.Text = xd.state;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox.clear();
        }

        private void saveDialog(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON|*.JSON|XML|*.XML|CSV|*.CSV|Yaml|*.Yaml";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    IDS ds = DSFactory.getInstance(saveFileDialog1.FileName);
                    ds.Save(pictureBox.getMemento());
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        private void loadDialog(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\CSharp\\ORTProjects\\PainterVector";
            openFileDialog1.Filter = "JSON|*.JSON|XML|*.XML|CSV|*.CSV|Yaml|*.Yaml|all|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.setMemento(DSFactory.getInstance(openFileDialog1.FileName).Load());
            }
        }

        private void pnlColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = pnlColor.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                pnlColor.BackColor = MyDialog.Color;
                xd.c = MyDialog.Color.Name;
            }
        }

        private void widthTrB_Scroll(object sender, EventArgs e)
        {
            xd.lw = ((TrackBar)sender).Value;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rectBtn_Click(object sender, EventArgs e)
        {

        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xd.state = "Move";
            stateTB.Text = xd.state;
        }

        private void rectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xd.state = "Rect";
            stateTB.Text = xd.state;
        }

        private void eclipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xd.state = "Ellipse";
            stateTB.Text = xd.state;
        }

        private void rRectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xd.state = "RRect";
            stateTB.Text = xd.state;
        }

        private void stateTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
