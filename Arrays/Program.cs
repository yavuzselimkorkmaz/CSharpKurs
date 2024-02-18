using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new string[] { "Engin","Derin","Salih" };

            string[] students3 = {"Mehmet","Ayşe","Abdullah"};

            //cok boyutlu diziler
            string[,] regions = new string[5,3 ]
            {
                {"istanbul","izmit","balıkkesir" },
                { "ankara","konya","kırıkkale"},
                {"antalya","adana","mersin" },
                {"rize","trabzon","samsun" },
                {"izmir","muğla","manisa" }
            };

            string[] bolge = {"marmara","ic anadolu","akdeniz","karadeniz","ege" };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine(bolge[i]+" bolgesi : ");
                for (int j =0;j<=regions.GetUpperBound(1);j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("\n");
            }


            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
