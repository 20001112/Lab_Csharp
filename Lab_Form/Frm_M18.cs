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
    public partial class Frm_M18 : Form
    {
        public Frm_M18()
        {
            InitializeComponent();
        }

        private void Btn_Products_Click(object sender, EventArgs e)
        {
            MessageBox.Show("恭喜你是管理員");
        }

        private void BtnValidatino01_Click(object sender, EventArgs e)
        {
            UserRole Role = UserRole.Admin;
            if (Role != UserRole.Admin)
            {
                Btn_Products.Enabled = true;
            }
            else
            {
                Btn_Products.Enabled = false;
            }


        }

        private void Btn_Validatino02_Click(object sender, EventArgs e)
        {
            UserRole Role = UserRole.Admin;
            //if (Role ==UserRole.Admin)
            //{
            //    Btn_Products.Enabled = true;
            //}
            //else
            //{
            //    Btn_Products.Enabled = false;
            //}
            switch (Role)
            {
                case UserRole.Admin:
                    Btn_Products.Enabled = true;
                    break;
                case UserRole.User:
                    Btn_Products.Enabled=false;
                    break;
            }
        }
        public enum UserRole//列舉可以取代其他地方的變數
        {
           Admin=2, User=4,
           Guest
        }

    }
}

