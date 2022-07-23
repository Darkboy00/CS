using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double n;
            Console.Write("Enter the number: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Absolute value: " + Math.Abs(n));
            Console.WriteLine("Upper sole: " + Math.Ceiling(n));
            Console.WriteLine("Bottom base: " + Math.Floor(n));
            Console.WriteLine("Square root: " + Math.Sqrt(n));
            Console.Read();
            
            string text1, text2;
            Console.Write("Enter text: ");
            text1 = Console.ReadLine();
            Console.Write("Enter text: ");
            text2 = Console.ReadLine();
            Console.WriteLine(string.Concat(text1, text2));
            Console.WriteLine(text1.Length);
            Console.WriteLine(text1.IndexOf("hello"));
            Console.WriteLine(text1.StartsWith("hi"));
            Console.WriteLine("Hello:" + text1.Trim());
            Console.WriteLine(text1.ToUpper());
            Console.WriteLine(text1.ToLower());
            Console.WriteLine(text1.Remove(4));
            Console.WriteLine(text1.Replace("a","A"));
            Console.WriteLine(text1.Substring(4));
            Console.Read();
            
            // Datetime
            Console.WriteLine("Day: " + DateTime.Now.Day);
            Console.WriteLine("Month: " + DateTime.Now.Month);
            Console.WriteLine("Year: " + DateTime.Now.Year);
            Console.WriteLine("Hour: " + DateTime.Now.Hour);
            Console.WriteLine("Minute: " + DateTime.Now.Minute);
            Console.WriteLine("Second: " + DateTime.Now.Second);
            Console.WriteLine("Short date: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Long date: " + DateTime.Now.ToLongDateString());
            Console.Read();
            */
            // Time span
            TimeSpan time;
            int dayDifference;
            DateTime date1, date2;
            date1 = Convert.ToDateTime("01.01.2020");
            date2 = Convert.ToDateTime("15.01.2020");
            time = date2 - date1;
            dayDifference = time.Days;
            Console.Write("Difference: " + dayDifference);
            Console.Read();
        }
    }
}