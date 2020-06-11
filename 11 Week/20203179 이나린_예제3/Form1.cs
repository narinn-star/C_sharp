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
            bool Valid = true;
            string contents = textBox1.Text;

            foreach (string word in Xwords)
            {
                if (contents.IndexOf(word) >= 0)
                {
                    Valid = false;
                    MessageBox.Show(word + "은(는) 금지어입니다", "결과");
                    break;
                }
                
            }
            if (Valid == true) MessageBox.Show("정상적인 게시물입니다", "결과");
        }
    }
}
