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
            //string[] cities = { "adana", "bursa", "ankara", "istanbul" };
            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities[2]);
            //Console.WriteLine(cities[3]);
            //Console.Read();10,20,30,40,50,60,70
;
            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.Read();

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 20 == 0 & numbers[i] % 30 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.Read();

            //string[] persons = { "ali", "veli", "ahmet", "eylül", "mehmet" };
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i]);
            //}
            //Console.Write(persons.Length);
            //Console.Read();

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //int total = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine(total);
            //Console.Read();

            //int[] numbers = { 20, 14, 13, 35, 1 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.Read();

            //string[] cities = { "Adana", "Ankara", "Zonguldak", "Malatya", "Istanbul", "Bursa" };
            //Array.Sort(cities);
            //Array.Reverse(cities);
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //Console.Read();

            //string[] persons = { "Buse", "Ali", "Hakan", "Furkan", "Eylül" };
            //int sequence;
            //Array.Sort(persons);
            //sequence = Array.IndexOf(persons, "Hakan");
            //Console.Write(sequence);
            //Console.Read();

            //int[] numbers = { 76, 43, 12, 55, 34 };
            //Console.WriteLine(numbers.Min());
            //Console.Write(numbers.Max());
            //Console.Read();

            //string[] cities = { "ankara", "adana", "istanbul", "bursa" };
            //foreach (string c in cities)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.Read();

            //int[] numbers = { 23, 55, 33, 16, 89, 70 };
            //int total = 0;
            //foreach (int x in numbers)
            //{
            //    total = total + x;
            //}
            //Console.Write(total);
            //Console.Read();

            //int[] numbers = { 34, 22, 11, 67, 89, 50 };
            //Array.Sort(numbers);
            //foreach (int num in numbers)
            //{
            //    if(num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            //Console.Read();

            string[] cities = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("City name: ");
                cities[i] = Console.ReadLine();
            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(cities[j]);
            }
            Console.Read();
        }
    }
}