using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            StreamWriter sw = new StreamWriter("C:\\Users\\Mehme\\OneDrive\\Masaüstü\\file1.txt");
            sw.Write("Hello world");
            sw.Close();

            StreamWriter sw2 = new StreamWriter(@"C:\Users\Mehme\OneDrive\Masaüstü\file2.txt");
            string text;
            Console.Write("Text: ");
            text = Console.ReadLine();
            sw2.Write(text);
            sw2.Close();
            */

            FileStream fs = new FileStream(@"C:\Users\Mehme\OneDrive\Masaüstü\File1 (2).txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string t = sr.ReadLine();
            while(t != null)
            {
                Console.WriteLine(t);
                t = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            Console.Read();
        }
    }
}