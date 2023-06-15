using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Lab_Form
{
    public partial class MyClass
    {
        void Method01()
        {
            MessageBox.Show("Method01");
                }
        private void Method02()
        {
            MessageBox.Show("Method02.private");
        }
        internal void Method03()
        {
            MessageBox.Show("Method03 internal");
        }
        public void Method04()
        {
            MessageBox.Show("Method04 public");
        }
        public void Method05()
        {
            Method01();
            Method02();
        }
    }
    public class Member///可以把會員用進去
    {
        public string Name;
        public int Age;
    }
    public class instanceAndStatic
    {
        public int instacnceVar = 0;
        public static int StaticVar = 0;
        internal static object staticCount;
    }
    public struct Employee
    {
       
     
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string EmployeeName, int EmployeeAge)
        {
            Name = EmployeeName;
            Age = EmployeeAge;

        }
    
    }

         //public string Name;
        //public int Age;
        //public int AverAge;

    public struct Product
    {
        public string Name;
        public decimal UnitPrice;

    }

        
        





    }
