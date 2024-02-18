using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My Name Is Cristiano Ronaldo"; 

            var result = sentence.Length; //karakter sayisi
            Console.WriteLine(result);

            var result2 = sentence.Clone(); //metni klonlar
            sentence = "My Name Is Lionel Messi";
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My Name");

            var result5 = sentence.IndexOf("Name"); //metin icindeki belli bir karakteri arar
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" "); //sondan arar

            var result8 = sentence.Insert(0, "Hello, "); //0.karatere sunu ekle

            var result9 = sentence.Substring(3,4); // 3.indeksten başlayıp 4 tane al

            var result10 = sentence.ToLower();

            var result11 = sentence.ToUpper();

            var result12 = sentence.Replace(" ","-");

            var result13 = sentence.Remove(2,4); //su indeksten itibaren su kadarini kaldir


            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (char harf in city)
            {
                Console.WriteLine(harf);
            }

            string city2 = "izmir";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
