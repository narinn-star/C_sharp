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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                int num02 = 0;
                string output = "구구단" + num + "단" + '\n';

                if (num >= 2 && num <= 9)
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        num02 = num * i;
                        output = output + num + "*" + i + "=" + num02 + "\n";
                    }
                    label2.Text = output;
                }
                else
                {
                    label2.Text = "2~9 사이의 수를 입력해 주세요";
                }
            }
            catch(Exception ee)
            {
                label2.Text = ee.Message;
            }
        }
    }
}
