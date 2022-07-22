using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        /*
        public static void print() 
        {
            Console.WriteLine("Hello World");
        }
        public static void totalMethod()
        {
            int n1 = 24, n2 = 30;
            int total = n1 + n2;
            Console.Write(total);
        }
        public static void textSpace()
        {
            Console.WriteLine();
            Console.WriteLine("**********");
            Console.WriteLine();
        }
        public static void consecutiveNumbers()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
        }
        
        public static void writeText(string p)
        {
            Console.WriteLine(p);
        }
        
        public static void writeText2(string p)
        {
            Console.Write(p);
        }
        public static int collection()
        {
            int n1, n2, t;
            n1 = 25;
            n2 = 35;
            t = n1 + n2;
            return t;
        }
        
        public static int collection(int n1, int n2)
        {
            int t;
            t = n1 + n2;
            return t;
        }
        */

        public static int average(int n1, int n2)
        {
            int total = (n1 + n2) / 2;
            return total;
        }
        public static int average(int n1, int n2, int n3)
        {
            int total = (n1 + n2 + n3) / 3;
            return total;
        }
        static void Main(string[] args)
        {
            /*
            print();
            textSpace();
            totalMethod();
            textSpace();
            consecutiveNumbers();
            Console.Read();
            writeText("Hello");
            Console.Read();

            Console.Write("Enter the word:");
            string word = Console.ReadLine();  
            writeText2(word);
            Console.Read();
            
            Console.WriteLine(collection());
            Console.Read();
            
            //Console.Write("Total:" + collection(10, 15));
            int n1, n2;
            Console.Write("Enter the first number:");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the second number:");
            n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("T:" + collection(n1, n2));
            Console.WriteLine(collection(9, 1));
            Console.Read();
            */
            Console.WriteLine(average(40, 50, 68));
            Console.Read();
        }
    }
}