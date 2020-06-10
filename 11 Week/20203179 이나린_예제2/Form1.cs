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
                string num = textBox1.Text;

                if (num.IndexOf("-") >= 0) label2.Text = "-빼고 입력해주세요.";
                else if (num.Length != 13) label2.Text = "정확히 입력해주세요.";
                else
                {
                    string num02 = num.Substring(6, 1);

                    if (num02 == "1" || num02 == "2") label2.Text = "올바르게 입력되었습니다.";
                    else if (num02 == "3" || num02 == "4") label2.Text = "2000년 이후 출생자는 사용이 불가능합니다.";
                    else label2.Text = "정확히 입력해주세요.";
                }
            }
            catch (Exception ee)
            {
                label2.Text = ee.Message;
            }
        }
    }
}
