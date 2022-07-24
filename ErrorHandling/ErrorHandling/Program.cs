using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                int n1, n2, t;
                Console.Write("n1:");
                n1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("n2:");
                n2 = Convert.ToInt16(Console.ReadLine());
                t = n1 * n2;
                Console.Write(t);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.Write(ex);
            }
            
            try
            {
                int n1, n2, t;
                Console.Write("n1:");
                n1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("n2:");
                n2 = Convert.ToInt16(Console.ReadLine());
                t = n1 * n2;
                Console.Write(t);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter numeric value");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value out of range");
            }
            */
            try
            {
                int n1, n2, t;
                Console.Write("n1:");
                n1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("n2:");
                n2 = Convert.ToInt16(Console.ReadLine());
                t = n1 * n2;
                Console.WriteLine(t);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.Write("Hi");
            }
            Console.Read();
        }
    }
}