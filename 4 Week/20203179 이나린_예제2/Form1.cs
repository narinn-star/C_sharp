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
                int korean = int.Parse(textBox1.Text);
                int english = int.Parse(textBox2.Text);
                int math = int.Parse(textBox3.Text);
                int total = (korean + english + math) / 3;
                
                string grade = "";

                if (total >= 90) grade = "수";

                else if (total >= 80) grade = "우";
           
                else if (total >= 70) grade = "미";
              
                else if (total >= 60) grade = "양";

                else grade = "가";
            
                label4.Text = "평균 : " + total + ", 성적 : " + grade;
            }
            catch (Exception ee)
            {
                label4.Text = ee.Message;
            }
        }
    }
}
