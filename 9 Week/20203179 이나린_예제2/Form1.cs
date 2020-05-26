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
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);

                if (num < 50000 && num >= 2)
                {
                    int sum = 0;
                    for (int i = 1; i <= num; i++)
                    {
                        sum += i;
                    }
                    label2.Text = "합 : " + sum;
                    count += 1;
                    label3.Text = "프로그램 실행 후 현재까지 이용횟수 : " + count + "회";
                }
                else label2.Text = "1~50000 사이의 수만 입력해 주세요";
            }
            catch(Exception ee)
            {
                label3.Text = ee.Message;
            }
        }
    }
}
