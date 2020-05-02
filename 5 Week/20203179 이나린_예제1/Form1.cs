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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                
                if (iData01 > iData02)
                {
                    label4.Text = "if~else 문으로 비교결과 : " + iData01 + " 이 " + iData02 + " 보다 크다";
                }
                else
                {
                    label4.Text = "if~else 문으로 비교결과 : " + iData02 + " 이 " + iData01 + " 보다 크다";
                }
            }
            catch(Exception ee)
            {
                label4.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);

                switch (iData01 > iData02)
                {
                    case true: label4.Text = "switch~case 문으로 비교결과 : " + iData01 + " 이 " + iData02 + " 보다 크다";
                        break;
                    default: label4.Text = "switch~case 문으로 비교결과 : " + iData02 + " 이 " + iData01 + " 보다 크다";
                        break;
                }
                    
            }
            catch (Exception ee)
            {
                label4.Text = ee.Message;
            }
        }
    }
}
