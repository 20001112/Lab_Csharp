using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;

namespace Lab_Console
{
    internal class Program
    {   
        static void Main(string[] args)
        { 
            MyClass mc = new MyClass();
            mc.Method04();
        
        
            Console.Write("請輸入姓名");
            string name =Console.ReadLine();
            Console.WriteLine("HELLO WORLD"+ name);
            Console.ReadKey();
        }
    }
}
