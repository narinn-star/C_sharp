using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_예제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
        }

        private void 출력ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
        }

        private void 출력ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
        }

        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
