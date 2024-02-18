using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            //if (number==10)
            //{
            //    Console.WriteLine("number is 10");
            //}else if (number ==20)
            //{
            //    Console.WriteLine("number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("number is not 10");
            //}

            ////single line if 
            //Console.WriteLine(number == 10 ? "number is 10" : "number is not 10");

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("number is 10");
            //        break;

            //        case 20:
            //        Console.WriteLine("number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("number is not 10 or 20");
            //        break;
            //}

            if (number>=0 &&number<=100)
            {
                Console.WriteLine("number is between 0 and 100");
            }
            else if(number>=100&&number<=200)
            {
                Console.WriteLine("number is between 100 and 200");
            }else if (number<0 ||number>200)
            {
                Console.WriteLine("number is less than 0 or more than 200");
            }


            Console.ReadLine();
        }
    }
}
