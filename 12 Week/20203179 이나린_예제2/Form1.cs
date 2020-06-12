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
        CheckBox[] Menu;
        const int count = 7;
        public Form1()
        {
            InitializeComponent();
            Menu = new CheckBox[count];
            Menu[0] = checkBox1;
            Menu[1] = checkBox2;
            Menu[2] = checkBox3;
            Menu[3] = checkBox4;
            Menu[4] = checkBox5;
            Menu[5] = checkBox6;
            Menu[6] = checkBox7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                if (Menu[i].Checked == true) 
                    listBox1.Items.Add(Menu[i].Text);
            }
        }
    }
}
