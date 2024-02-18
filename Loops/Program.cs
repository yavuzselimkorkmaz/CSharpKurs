using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //formethod();
            //ForWhile();
            //ForDoWhile();

            string[] names = {"ismail","kerem","yavuz" };
            foreach (string isim in names)
            {
                Console.WriteLine(names);
            }

            Console.ReadLine();
        }

        private static void ForDoWhile()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void ForWhile()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("now number is {0}", number);
        }

        private static void formethod()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
