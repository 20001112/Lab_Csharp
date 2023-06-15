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
    public partial class Form_M04 : Form
    {
        public Form_M04()
        {
            InitializeComponent();
        }

        private void Form_M04_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            la Frm=new la();
            Frm.Show();
        }

        private void Math_Click(object sender, EventArgs e)
        {
            MyFirstMethod();
        }
        void MyFirstMethod()
        {
            string Name = "John Wick";
            MessageBox.Show("MY name is" + Name + "this is my first method");
        }

        private void ReturnMethod_Click(object sender, EventArgs e)
        {
            string birthYearResult=BirthYear(20);
            MessageBox.Show(birthYearResult);
        }
        string BirthYear(int Age)
        {
            int bYear =DateTime.Now.Year-Age;
            string result = "出生於" + bYear + "年";
            return result;
        }

        private void btnFirstClass_Click(object sender, EventArgs e)
        {
            MyClass mc= new MyClass();
            //mc.Method01();
            //mc.Method02();
            mc.Method03();
            mc.Method04();
        }

        private void 封裝_Click(object sender, EventArgs e)
        {
           MyClass mc= new MyClass();
            mc.Method05();
        }

        private void btn_MypartialClass_Click(object sender, EventArgs e)
        {
        MyClass mc =new MyClass();
        mc.Method06ParitialClass();
        mc.Method03();
        }

        private void NewMember_Click(object sender, EventArgs e)
        {
            Member member1= new Member();
            member1.Name = "明哲";
            member1.Age = 20;
            string mem1Name = member1.Name;
            int mem1Age = member1.Age;

            MessageBox.Show("Name" + mem1Name + ",Age" + mem1Age);
            Member member2 = new Member
            {   
                Name = "柏翔",
                Age = 20

            };
            MessageBox.Show("Name" + member2.Name+",Age"+member2.Age);
        }
    }   
}
