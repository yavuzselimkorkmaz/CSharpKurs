using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
               //Console.WriteLine("Hello World!");

                //Value Types

                int number1 = 10; //int deger tipidir
                Console.WriteLine("number 1 is : {0}", number1);
                long number2 = -200000000000000000;
                Console.WriteLine("number 2 is : {0}", number2); //long daha cok karakter tutar ama int den 2 katı yer kaplar deger tipi 
                short number3 = -32768; //int den daha az karakter tutar ve daha az yer kaplar
                Console.WriteLine("number 3 is : {0}", number3);
                byte number4 = 2; //0 ile 255 arası değer alır en az yer kaplayan tam sayı veri tipi
                Console.WriteLine("number 4 is : {0}", number4);
                double number5 = 10.4; //double ondalikli
                Console.WriteLine("number 5 is : {0}", number5);
                decimal number6 = 2.897985649786M; //doubledan daha cok virgul tutar //sona m konur //daha hassas degerler hesaplamalar icin

                Console.WriteLine((int)Days.Friday);

                var number7 = 10;
                //bundan sonra number7 artik integer 




                bool condition = false; //true ya da false der 1 ya da 0 dondurur if else icin siklikla kullanilir

                char character = 'A'; //tek bir karakter tutar ascii tablosundan alınır

                string metin = "merhaba"; //char dizisi

                Console.WriteLine(Days.Monday);
            


                Console.ReadLine();
        }

        enum Days
        {
            Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }


    }
}
