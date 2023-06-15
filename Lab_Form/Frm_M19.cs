using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M19 : Form
    {
        public Frm_M19()
        {
            InitializeComponent();
        }
        //private List<Empoyee> employees = new List<Empoyee>(); // 声明一个列表来存储员工
        int Count=0;
        int totalAge = 0;
        int aveage = 0;
        string EmpliyeeResult = "員工\n---------------------\n";
        private void Btn_AddEmployee_Click(object sender, EventArgs e)
        {
            //Empoyee emp = new Empoyee(); // 创建 Employee 结构的实例
            //emp.Name = txt_Name.Text;
            //emp.Age = int.Parse(txt_Year.Text);
            //employees.Add(emp); // 将员工添加到列表中

            //decimal sum = 0;
            //foreach (Empoyee employee in employees)
            //{
            //    sum += employee.Age;
            //}
            //decimal average = sum / employees.Count; // 使用员工数量作为分母
            //Employee empP =new Employee();
            //empP.Name = txt_Name.Text;
            //empP.Age = int.Parse(txt_Year.Text);
            //Employee emp = new Employee(txt_Name.Text,int.Parse(txt_Year.Text));
            int age = 0;
            bool isNum = int.TryParse(txt_Year.Text, out age);
            if (isNum == true)
            { Employee emp = new Employee(txt_Name.Text, age);
            Count++;
                totalAge += emp.Age;
                aveage = totalAge / Count;
                EmpliyeeResult += emp.Name + ", " + emp.Age + "年齡平均數"+ aveage + "\n";
            }
            else
            {
                MessageBox.Show("好好打字");
                txt_Year.Clear();
                txt_Year.Focus();
            }

        }


        private void Btn_look_Click(object sender, EventArgs e)
        {
            Lab_lookEmployee.Text = EmpliyeeResult;
        }

        private void Frm_M19_Load(object sender, EventArgs e)
        {

        }
    }
}
