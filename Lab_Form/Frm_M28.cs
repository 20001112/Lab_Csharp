using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M28 : Form
    {
        public Frm_M28()
        {
            InitializeComponent();
        }
        void Swap (ref int A,ref int B)
        {
            int T = A;
            A= B; 
            B = T;
        }
        void Swap(ref string a,ref string b)
        {
            string T = a;
            a= b;
            b= T;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a=100, b=1000;
            MessageBox.Show("a" + a + ",b" + b);
            Swap(ref a,ref b);
            MessageBox.Show("a" + a + ",b:" + b);

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            String a="aaa", b = "bbb";
            MessageBox.Show("a" + a + ",b" + b);
            Swap(ref a, ref b);
            MessageBox.Show("a" + a + ",b" + b);


        }
        void GenericSwap<Tt>(ref Tt A,ref Tt B)
        {
            Tt T=A;
            A= B;
            B= T;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ia=100, ib=200;
            GenericSwap<int>(ref ia,ref ib);
            MessageBox.Show("a:" + ia + ",b" + ib);
            string a = "aaa", b = "bbb";
            GenericSwap<string>(ref a, ref b);
            MessageBox.Show("a" + a + ",b" + b);

        }
    }
}
