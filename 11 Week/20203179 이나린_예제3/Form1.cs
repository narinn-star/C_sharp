using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203179_이나린_예제3
{
    public partial class Form1 : Form
    {
        string[] Xwords;
        public Form1()
        {
            InitializeComponent();
            Xwords = new string[4];
            Xwords[0] = "바보";
            Xwords[1] = "메롱";
            Xwords[2] = "님아";
            Xwords[3] = "8억";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
