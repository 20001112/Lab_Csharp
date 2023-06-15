using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M24_loop : Form
    {
        public Frm_M24_loop()
        {
            InitializeComponent();
        }

        private void Btn_While_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            while (i < 10) {
                result += i + "\n";
                i++;
                    }
            MessageBox.Show(result);
        }

        private void Btn_DO_Click(object sender, EventArgs e)
        {
            int i= 0;
            string result = "";
            do
            {
                result += i + "\n";
                i++;
            } while (i < 10);
            MessageBox.Show(result);
        }

        private void Btn_For_Click(object sender, EventArgs e)
        {
            int method ;
            string result="" ;
            string resultmethod = "";

                for (int i = 1;  i < 10; i++)
                {
                
                
                   for (int j = 0; j < 10; j++)
                    {
                        j = i;
                        method = i * j;
                        resultmethod = method.ToString();
                        result += i + "*" + j + "我是分隔線"+resultmethod + "\n";
                    }
                
                }
                MessageBox.Show(result);









        }
    }
}
