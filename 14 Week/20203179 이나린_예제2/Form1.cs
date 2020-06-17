using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_예제2
{
    public partial class Form1 : Form
    {
        bool Drag = false;
        Point pPoint;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            pPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag == true)
            {
                Pen Penoption;

                Point fPoint = new Point(e.X, e.Y);
                if (comboBox1.SelectedIndex == 0)
                    Penoption = new Pen(Color.Black);
                else if (comboBox1.SelectedIndex == 1)
                    Penoption = new Pen(Color.Red);
                else if (comboBox1.SelectedIndex == 2)
                    Penoption = new Pen(Color.Blue);
                else
                    Penoption = new Pen(Color.Yellow);

                if (radioButton2.Checked == true)
                {
                    Penoption.Width = 3;
                }

                if (comboBox2.SelectedIndex == 0)
                    Penoption.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                else if (comboBox2.SelectedIndex == 1)
                    Penoption.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                else
                    Penoption.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

                Graphics G = panel1.CreateGraphics();
                G.DrawLine(Penoption, pPoint, fPoint);
                pPoint = fPoint;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
