using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bookshelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = 0;
            string selection;
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Turkish Books Category              **  Foreign Books Category                      **");
            Console.WriteLine();
            Console.WriteLine("**  1-Wren: Reşat Nuri                  **  7-Tuna Guide: Jules Verne                   **");
            Console.WriteLine();
            Console.WriteLine("**  2-Wild: Yakup Kadri                 **  8-A Northern Adventure: Jack London         **");
            Console.WriteLine();
            Console.WriteLine("**  3-Fly Grocery Store: Halide Edip    **  9-Ward Six: Anton Çehov                     **");
            Console.WriteLine();
            Console.WriteLine("**  4-Dangerous Games: Oğuz Atay        **  10-Gambler: Dostoyevski                     **");
            Console.WriteLine();
            Console.WriteLine("**  5-From the days I passed: H.A.Yücel **  11-A Tale of Two Cities: C.Dickens          **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf: S.Ali            **  12-Cherry Orchard: Anton Çehov              **");
            Console.WriteLine();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** Operations Menu *****");
            Console.WriteLine();
            Console.WriteLine("1-Inquire Price");
            Console.WriteLine("2-New Reader Registration");
            Console.WriteLine("3-Book of the Day");
            Console.WriteLine("4-Book Archive");
            Console.WriteLine("5-Buy New Book");
            Console.WriteLine("6-Game");
            Console.WriteLine();
            Console.Write("The transaction number you want to do: ");
            char process;
            process = Convert.ToChar(Console.ReadLine());
            if(process == '1')
            {
                Console.WriteLine();
                Console.Write("Enter the number of the book: ");
                string n;
                n = Console.ReadLine();
                switch (n)
                {
                    case "1": Console.Write("Wren: 12"); break;
                    case "2": Console.Write("Wild: 14"); break;
                    case "3": Console.Write("Fly Grocery Store: 16"); break;
                    case "4": Console.Write("Dangerous Games: 11"); break;
                    case "5": Console.Write("From the days I passed: 8"); break;
                    case "6": Console.Write("Kuyucaklı Yusuf: 13"); break;
                    case "7": Console.Write("Tuna Guide: 17"); break;
                    case "8": Console.Write("A Northern Adventure: 4"); break;
                    case "9": Console.Write("Ward Six: 5"); break;
                    case "10": Console.Write("Gambler: 10"); break;
                    case "11": Console.Write("A Tale of Two Cities: 13"); break;
                    case "12": Console.Write("Cherry Orchard: 6"); break;
                    default: Console.Write("No such book exists."); break;
                }
            }
            if (process == '2')
            {
                Console.WriteLine("***** New Reader Registration *****");
                string name, surname, university;
                Console.Write("Your name: ");
                name = Console.ReadLine();
                Console.Write("Your surname: ");
                surname = Console.ReadLine();
                Console.Write("Your university: ");
                university = Console.ReadLine();

                string f = @"C:\Users\Mehme\OneDrive\Masaüstü\user.txt";
                StreamWriter sw = new StreamWriter(f);
                sw.WriteLine("Your name: " + name);
                sw.WriteLine("Your surname: " + surname);
                sw.WriteLine("Your university: " + university);
                sw.Close();
            }
            if (process == '3')
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine();
                Console.WriteLine("***** Today's Book: Wren *****");
                Console.WriteLine();
                Console.WriteLine("******************************");
            }
            if (process == '4')
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\Mehme\OneDrive\Masaüstü\Books.txt",FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string t = sr.ReadLine();
                while (t != null)
                {
                    Console.WriteLine(t);
                    t = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("******************************");
            }
            if (process == '5')
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Book number: ");
                    selection = Console.ReadLine();
                    if(selection == "1")
                    {
                        totalPrice = totalPrice + 12;
                    }
                    else if(selection == "2")
                    {
                        totalPrice = totalPrice + 14;
                    }
                    else if (selection == "3")
                    {
                        totalPrice = totalPrice + 16;
                    }
                    else if (selection == "4")
                    {
                        totalPrice = totalPrice + 11;
                    }
                    else if (selection == "5")
                    {
                        totalPrice = totalPrice + 8;
                    }
                    else if (selection == "6")
                    {
                        totalPrice = totalPrice + 13;
                    }
                    else if (selection == "7")
                    {
                        totalPrice = totalPrice + 17;
                    }
                    else if (selection == "8")
                    {
                        totalPrice = totalPrice + 4;
                    }
                    else if (selection == "9")
                    {
                        totalPrice = totalPrice + 5;
                    }
                    else if (selection == "10")
                    {
                        totalPrice = totalPrice + 10;
                    }
                    else if (selection == "11")
                    {
                        totalPrice = totalPrice + 13;
                    }
                    else if (selection == "12")
                    {
                        totalPrice = totalPrice + 6;
                    }
                    else 
                    
                        Console.WriteLine("no book number");
                        Console.WriteLine();
                        Console.Write("Would you like to buy another book: ");
                        string answer = Console.ReadLine();
                        if (answer == "n" || answer == "N" || answer == "no" || answer == "NO")
                            break;
                    
                }
                Console.WriteLine("Total amount: " + totalPrice);
            }
            if (process == '6')
            {
                int prediction = 0;
                Random rnd = new Random();
                int n = rnd.Next(1, 100);
                while(n != prediction)
                {
                    Console.Write("Enter the number: ");
                    prediction = Convert.ToInt16(Console.ReadLine());
                    if(prediction > n)
                    {
                        Console.WriteLine("smaller");
                    }
                    if (prediction < n)
                    {
                        Console.WriteLine("bigger");
                    }
                    if(prediction == n)
                    {
                        Console.WriteLine("you know");
                        break;
                    }
                }
            }
            Console.Read();
        }
    }
}