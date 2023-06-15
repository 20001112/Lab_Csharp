using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M32_String : Form
    {
        public Frm_M32_String()
        {
            InitializeComponent();
        }

        private void Btn_String_Click(object sender, EventArgs e)
        {
            String str1 = "AAAA";
            str1 = "BBBB";
            string str2 = str1;
            str2 = "CCCC";
            MessageBox.Show("sb1:" + str1.ToString() + "\nsb2:" + str2.ToString());

        }

        private void Btn_StringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("AAAAA");
            StringBuilder sb2 = sb1;
            sb2.Append("BBBBB");
            MessageBox.Show("sb1:" + sb1.ToString() + "\nsb2:" + sb2.ToString());
        }

        private void Btn_path_Click(object sender, EventArgs e)
        {
            string dir = @"C:\\Users\\User\\Desktop\\star.jpg";
            string result = "";
            result += Path.GetFullPath(dir) + "\n";
            result += Path.GetFileName(dir) + "\n";
            result += Path.GetExtension(dir) + "\n";
            result += Path.GetDirectoryName(dir);
            MessageBox.Show(result);
        }

        private void Btn_Vaild_Click(object sender, EventArgs e)
        {

        }
        bool isStrongPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z].{8-16}$)");

        }
    }
}
