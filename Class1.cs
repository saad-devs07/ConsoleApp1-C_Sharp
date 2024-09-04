using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1 : Class2
    {
        /* public void abc()
        {
            Console.WriteLine("This is a void method!");
        }

        public string def()
        {
            return "This is a string method!";
        }

        public int ghi()
        {
            return 123456789;
        }

        public int jkl(int a)
        {
            return a;
        }

        public string mno(string b)
        {
            return "Welcome " + b;
        }

        public void pqr(string c)
        {
            Console.WriteLine("Assalam o Alaikum " + c);
        } */

        public static void abc(string n)
        {
            Console.WriteLine("Welcome " + n);
        }

        public static void abc(string n, string f_n)
        {
            Console.WriteLine("Welcome " + n + ", s/o " + f_n);
        }

        public static void abc(int age)
        {
            Console.WriteLine("Your age is " + age);
        }

        public static void abc(string n, int ph)
        {
            Console.WriteLine("Welcome " + n + ", s/o " + ph);
        }

    }
}
