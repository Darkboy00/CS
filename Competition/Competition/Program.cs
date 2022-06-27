using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();

            int question = 1;
            string answer;
            if(question == 1)
            {
                Console.WriteLine("Is it the capital of Turkey?");
                Console.WriteLine();
                Console.WriteLine("A) Istanbul");
                Console.WriteLine("B) Ankara");
                Console.WriteLine("C) Izmir");
                Console.WriteLine("D) Bursa");
                Console.WriteLine();
                Console.Write("Your answer:");
                answer = Console.ReadLine();
                
                if(answer == "b" || answer == "B")
                {
                    question = question + 1;
                }
                else
                {
                    Console.Write("The answer is wrong, your total score is: 0");
                }
            }
            if (question == 2)
            {
                Console.WriteLine("In what year was the republic declared?");
                Console.WriteLine();
                Console.WriteLine("A) 1920");
                Console.WriteLine("B) 1921");
                Console.WriteLine("C) 1922");
                Console.WriteLine("D) 1923");
                Console.WriteLine();
                Console.Write("Your answer:");
                answer = Console.ReadLine();

                if (answer == "d" || answer == "D")
                {
                    question = question + 1;
                }
                else
                {
                    Console.Write("The answer is wrong, your total score is: 1");
                }
            }
            if (question == 3)
            {
                Console.WriteLine("In which region is Adana located?");
                Console.WriteLine();
                Console.WriteLine("A) Mediterrenian");
                Console.WriteLine("B) Marmara");
                Console.WriteLine("C) Black Sea");
                Console.WriteLine("D) Central Anatolia");
                Console.WriteLine();
                Console.Write("Your answer:");
                answer = Console.ReadLine();

                if (answer == "a" || answer == "A")
                {
                    Console.Write("Congratulations, you got the questions right.");
                }
                else
                {
                    Console.Write("The answer is wrong, your total score is: 2");
                }
            }
            Console.Read();
        }
    }
}