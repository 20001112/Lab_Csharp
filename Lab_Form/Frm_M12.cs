using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
            
        }
        int count = 3;

        private void Btn_01_Click(object sender, EventArgs e)
        {

            count += 2;
            LabCount.Text = "Count"+count;
            
        }

        private void Lab_2_Click(object sender, EventArgs e)
        {
            int result = ++count;
            LabCount.Text = "Count" + count;
            Lab_Then.Text="Result"+ result;
        }

        private void Lab_Then_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = count++;
            LabCount.Text = "Count" + count;
            Lab_Then.Text = "Result" + result;

        }
        public int c = 1000;
        private void Btn_04_Click(object sender, EventArgs e)
        {
            
        }
        instanceAndStatic ins = new instanceAndStatic();
        private void instanceVar_Click(object sender, EventArgs e)
        {
            ins.instacnceVar++;
            instanceCount.Text = "instance Count"+ins.instacnceVar;
        }

        private  void staticVar_Click(object sender, EventArgs e)
        {
            instanceAndStatic.StaticVar++;
            staticCount.Text = "static Count" + instanceAndStatic.StaticVar;
        }

        private void HelloFrom_Click(object sender, EventArgs e)
        {
            la frm = new la();
            frm.Show();
        }

    }
}
