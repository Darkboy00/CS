using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World");

            //multidimensional arrays 
            int[,] numbers = new int[2, 3];
            numbers[0, 0] = 10;
            numbers[0, 1] = 20;
            numbers[0, 2] = 25;
            numbers[1, 0] = 30;
            numbers[1, 1] = 40;
            numbers[1, 2] = 45;
            Console.Write(numbers[0, 1]);
            Console.Read();
            
            Console.WriteLine("*****");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*****");
            }
            Console.Read();
            
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            */

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}