using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M24 : Form
    {
        public Frm_M24()
        {
            InitializeComponent();
        }
        bool flag = true;

        private void Btn_Reverse_Click(object sender, EventArgs e)
        {
            //bool isflag = true; Btn_Reverse.BackColor = Color.RoyalBlue;

            //if (flag== true)
            //{
            //    Btn_Reverse.BackColor = Color.RoyalBlue;
            //    //flag = false;
            //}
            //else
            //{
            //    Btn_Reverse.BackColor = Color.Gold;
            //    //flag = true;
            //}
            //flag = !flag;
        }

        private void Btn_If_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(i>0)
            {
                MessageBox.Show("true");
            }

        }

        private void Btn_elseif_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(i>0)
            {
                MessageBox.Show("讚讚");
            }
            else
            {
                MessageBox.Show("你又沒麻掉條件");
            }
        }

        private void Btn_IfElseIf_Click(object sender, EventArgs e)
        {   int score= 0;
            bool isScoreNum =int.TryParse(txt_Score.Text,out score);
            if (isScoreNum)
            {
                if (score >= 90 && score <= 100)
                {
                    Lab_Grade.Text = "A級";
                }
                else if (score >= 80 && score < 90)
                {
                    Lab_Grade.Text = "B級";
                }
                else if (score >= 70 && score < 80)
                {
                    Lab_Grade.Text = "C級";
                }
                else if (score >= 60 && score < 70)
                {
                    Lab_Grade.Text = "D級";
                }
                else
                {
                    Lab_Grade.Text = "E級";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void Btn_switch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("晚上要不要逛夜市嗎?", "問妳喔", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("讚讚 好約");
                        break;
                case DialogResult.No:
                    MessageBox.Show("有夠派糾");
                    break;

            }


            
        }

        //private void three_Click(object sender, EventArgs e)
        //{
        //Btn_Reverse.BackColor=flag ?Color.RoyalBlue
        //}
    }
}
