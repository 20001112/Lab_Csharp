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
    public partial class Frm_M32 : Form
    {
        public Frm_M32()
        {
            InitializeComponent();
        }

        private void Btn_foreach_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            {   
                //if(item.GetType()!=typeof(Button))
                //{
                //    continue;
                //}
                if(!(item is Button))
                    
                item.BackColor = Color.Black;
                item.ForeColor = Color.Pink;
                item.Left -= 10;
                item.Top -= 10;
            }    
        }

        private void Btn_While_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            do
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                result = i + "\n";
                i++;
            } while (i < 10);

            MessageBox.Show(result);



        }
    }
}
