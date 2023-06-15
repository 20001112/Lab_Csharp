using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M08 : Form
    {
        public Frm_M08()
        {
            InitializeComponent();
        }

        private void RegisterEvent_Click(object sender, EventArgs e)
        {
            this.Register01.Click += new EventHandler(Register01Click);
            Register02.Click += Register02_Click;
        }

        private void Register02_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Register02");
        }

        private void Register01Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register");
        }



        private void btnSetProperty_Click(object sender, EventArgs e)
        {
            btnSetProperty.Text = "設定屬性";
            btnSetProperty.BackColor = Color.Black;
            btnSetProperty.ForeColor = Color.Pink;
        }

        private void paybox_TextChanged(object sender, EventArgs e)
        {
            
            decimal Aumount =decimal.Parse(paybox.Text);
          
            if (cmbDiscount.Text == "50%off")
            {
               

            }


        }

        decimal Discount50off(decimal amount)
        {
            return amount * 0.5m;
        }
        decimal Discount20off(decimal amount)
        {
            return amount *0.8m;
        }

        private void messagebox_Click(object sender, EventArgs e)///寫yes或no
        {   
            DialogResult result = MessageBox.Show("晚上要不要逛夜市嗎?", "問妳喔", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("好咖");
            }
            else if (result == DialogResult.No)
            {
                DialogResult result1 = MessageBox.Show("確定不去嗎?", "問妳喔", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result1 == DialogResult)
                {
                    MessageBox.Show("有夠派糾");
                }
            }

        }

        private void HelloFrom_Click(object sender, EventArgs e)////可以跳其他地方
        {
            la Frm =new la();
            DialogResult result = Frm.ShowDialog();
        }

        private void Frm_M08_Load(object sender, EventArgs e)
        {

        }
    }
}
