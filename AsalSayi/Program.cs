using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPrimeNumber(20);
            Console.ReadLine();
        }

        static void IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
               var bolum = number % i;
                if (bolum==0)
                {
                    result = false;
                    break;
                }
            }

            if (result==true)
            {
                Console.WriteLine("sayi asal");
            }
            else
            {
                Console.WriteLine("sayi asal degil");
            }
        }
    }
}
