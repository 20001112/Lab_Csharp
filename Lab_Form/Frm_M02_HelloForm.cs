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
    public partial class la : Form
    {
        public la()
        {
            InitializeComponent();
        }

        private void button_Hello_Click(object sender, EventArgs e)
        {//todo 等等要做的事
            string name= txtname.Text;
            System.Windows.Forms.MessageBox.Show("Hello"+name);

        }

        private void la_Load(object sender, EventArgs e)
        {

        }

        private void StaticVar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(instanceAndStatic.StaticVar.ToString());
        }
    }
}
