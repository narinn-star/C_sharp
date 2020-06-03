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
        int[] result = { 0, 0, 0, 0, 0 };
        int MaxNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < result.Length; i++)
            {
                MaxNum += 1;
                result[i] = MaxNum;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string output = "배열내용 : ";
            foreach (int Num in result)
            {
                output += Num + ", ";
            }
            label1.Text = output;
        }
    }
}
