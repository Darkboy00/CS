using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string city;
            //Console.Write("City name:");
            //city = Console.ReadLine();
            //if(city == "Istanbul") 
            //{
            //    Console.Write("right city");
            //}
            //else
            //{
            //    Console.Write("wrong city");
            //}
            //Console.Read();

            //int number;
            //Console.Write("Enter the number: ");
            //number = Convert.ToInt16(Console.ReadLine());
            //if(number == 23)
            //{
            //    Console.Write("right number");
            //}
            //else
            //{
            //    Console.Write("wrong number");
            //}
            //Console.Read();

            //int e1, e2, avg;
            //Console.Write("e1: ");
            //e1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("e2: ");
            //e2 = Convert.ToInt16(Console.ReadLine());
            //avg = (e1 + e2) / 2;
            //Console.Write("avg: " + avg);
            //if(avg >= 50)
            //{
            //    Console.Write("-You passed");
            //}
            //else
            //{
            //    Console.Write("-You stayed");
            //}
            //Console.Read();

            //string user, password;
            //Console.Write("Your user name:");
            //user = Console.ReadLine();
            //Console.Write("Your password:");
            //password = Console.ReadLine();
            //if(user == "admin" & password == "123456")
            //{
            //    Console.Write("welcome");
            //}
            //else
            //{
            //    Console.Write("error");
            //}
            //Console.Read();

            //int e1, e2, e3, avg;
            //Console.Write("e1:");
            //e1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("e2:");
            //e2 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("e3:");
            //e3 = Convert.ToInt16(Console.ReadLine());
            //avg = (e1 + e2 + e3) / 3;
            //Console.Write("avg: " + avg);
            //if(avg <= 49)
            //{
            //    Console.Write(" mediocre");
            //}
            //if (avg >= 50 & avg <= 65)
            //{
            //    Console.Write(" middle");
            //}
            //if (avg >= 66 & avg <= 79)
            //{
            //    Console.Write(" good");
            //}
            //if (avg >= 80)
            //{
            //    Console.Write(" very good");
            //}
            //Console.Read();

            //char character;
            //Console.Write("Enter character:");
            //character = Convert.ToChar(Console.ReadLine());
            //if(character != 'a')
            //{
            //    Console.Write("Not the letter a");
            //}
            //else
            //{
            //    Console.Write("The letter a");
            //}
            //Console.Read();

            //byte plate;
            //Console.Write("Enter the plate: ");
            //plate = byte.Parse(Console.ReadLine());
            //switch (plate)
            //{
            //    case 1:Console.Write("Hello Adana"); break;
            //    case 2: Console.Write("Hello Adiyaman"); break;
            //    case 3: Console.Write("Hello Afyon"); break;
            //    default:Console.Write("This city does not have information"); break;
            //}
            //Console.Read();

            string season;
            Console.Write("Enter the season: ");
            season = Console.ReadLine();
            switch (season)
            {
                case "summer": Console.WriteLine("June - July - August"); break;
                case "spring": Console.WriteLine("March - April - May"); break;
                case "autumn": Console.WriteLine("September - October - November"); break;
                case "winter": Console.WriteLine("December - January - February"); break;
                default: Console.WriteLine("Wrong season"); break;
            }
            Console.Read();
        }
    }
}