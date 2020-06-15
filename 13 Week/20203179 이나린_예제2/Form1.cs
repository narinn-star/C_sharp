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
            DialogResult answer = MessageBox.Show("물어볼까요?", "질문", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes) label1.Text = "결과 : 예";
            else label1.Text = "결과 : 아니요";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult open = openFileDialog1.ShowDialog();
                if (open == DialogResult.OK)
                    label2.Text = "파일명 : " + openFileDialog1.FileName;
                else
                    label2.Text = "파일열기를 취소함";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message, "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
