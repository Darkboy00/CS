using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Random r = new Random();
            n1 = r.Next(0, 51);
            n2 = r.Next(0, 51);
            Console.WriteLine(n1 + " " + n2);

            Random rn = new Random();
            int city;
            string[] cities = { "Adana", "Ankara", "Bursa", "İstanbul" };
            city = rn.Next(0, cities.Length);
            Console.WriteLine(cities[city]);

            //Captcha
            int d1, d2, d3, d4;
            Random rnd = new Random();
            d1 = rnd.Next(0, 10);
            d2 = rnd.Next(0, 10);
            d3 = rnd.Next(0, 10);
            d4 = rnd.Next(0, 10);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            string[] characters = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E" };
            Console.WriteLine(d1 + characters[d2] + d3 + characters[d4]);
            Console.Read();
        }
    }
}