using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M34_Read : Form
    {
        public Frm_M34_Read()
        {
            InitializeComponent();
        }

        private void Btn_Streamread_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../../obj/read.txt", Encoding.UTF8);
            txtReadWrite.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void Btn_Streamwriten_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("../writer.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
            sw.Write(txtReadWrite.Text);
            sw.Close();
            fs.Close();
        }

        private void Btn_down_Click(object sender, EventArgs e)
        {
            int x = 0;
            string result = "";
            while(x<10)
            {
                result += x++ + "\n";
            }
             ShowResult(result);
        }
        void ShowResult(string result)
        {
            MessageBox.Show(result);

        }

        private void Btn_try_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                string result = "";
                for (int i = 0; i <= arr.Length; i++)
                {
                    result += arr[i] + "\n";
                }
                ShowResult(result);
            }
            catch(IndexOutOfRangeException ex)
            { MessageBox.Show(ex.Message); 
            }catch(AppDomainUnloadedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
