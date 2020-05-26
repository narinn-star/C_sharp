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
        int accountA = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int accountB = 0;
            try
            {
                int total = int.Parse(textBox1.Text);
                accountA += total;
                accountB += total;

                label2.Text = "A 계좌총액 : " + accountA + "원";
                label3.Text = "B 계좌총액 : " + accountB + "원";
            }
            catch(Exception ee)
            {
                label2.Text = ee.Message;
                label3.Text = ee.Message;
            }
        }
    }
}
