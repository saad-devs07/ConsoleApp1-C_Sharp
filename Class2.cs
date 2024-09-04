using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        public Class2()
        {
            Console.WriteLine("Autofire Constructor from Class2!");
        }

        public void table()
        {
            Console.WriteLine("Enter number whose table you want, also enter starting and ending number of this:");
            int t, s, e;
            t = int.Parse(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            int t1 = s;
            while (t1 <= e)
            {
                Console.WriteLine(t + " x " + t1 + " = " + (t * t1));
                t1++;
            }

        }
    }
}
