using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(addition(5, 2));
            Console.WriteLine(extraction(5, 2));
            Console.WriteLine(multiplication(5, 2));
            Console.WriteLine(division(5, 2));
            Console.Read();
        }
        static int addition(int n1, int n2)
        {
            return n1 + n2;
        }
        static int extraction(int n1, int n2)
        {
            return n1 - n2;
        }
        static int multiplication(int n1, int n2)
        {
            return n1 * n2;
        }
        static float division(float n1, float n2)
        {
            return n1 / n2;
        }
    }
}