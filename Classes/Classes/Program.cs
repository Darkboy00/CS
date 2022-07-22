using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Car class
            Car car = new Car();
            car.brand = "Brand x";
            car.speed = 180;
            car.model = "2021";
            car.engine = 1.6;
            car.color = "White";
            Console.WriteLine("Brand:" + car.brand);
            Console.WriteLine("Speed:" + car.speed);
            Console.WriteLine("Model:" + car.model);
            Console.WriteLine("Engine:" + car.engine);
            Console.WriteLine("Color:" + car.color);

            // Customer class
            Customer c = new Customer();
            c.name = "Mehmet";
            c.surname = "Kaymakcı";
            c.id = 1;
            c.city = "İstanbul";

            Console.WriteLine(c.id + "-" + "Name Surname: " + c.name + " " + c.surname + " City: " + c.city);
            Console.Read();
            

            Customer c = new Customer();
            Console.Write("Enter the id value:");
            c.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your name:");
            c.Name = Console.ReadLine();
            Console.Write("Your surname:");
            c.Surname = Console.ReadLine();
            Console.Write("Your city:");
            c.city = Console.ReadLine();
            Console.WriteLine(c.id + "-" + c.Name + " " + c.Surname + " " + c.city);
            Console.Read();
            */
            Parrot p = new Parrot();
            p.type = "Parrot";
            p.speed = 50;
            p.name = "Sultan";
            p.color = "Yellow - Red";
            p.weight = 1650;
            p.makeSound();

            Console.WriteLine("Type: " + p.type);
            Console.WriteLine("Name:" + p.name);
            Console.WriteLine("Speed:" + p.speed);
            Console.WriteLine("Weight:" + p.weight);
            Console.WriteLine("Color:" + p.color);
            Console.WriteLine("Sound:" + p.makeSound());

            Console.WriteLine();
            Console.WriteLine("**********");
            Crow c = new Crow();
            c.weight = 1350;
            c.speed = 80;
            c.name = "MountainCrow";
            c.color = "Black";
            c.type = "Crow";
            c.makeSound();

            Console.WriteLine("Weight: " + c.weight);
            Console.WriteLine("Speed: " + c.speed);
            Console.WriteLine("Name: " + c.name);
            Console.WriteLine("Color: " + c.color);
            Console.WriteLine("Type: " + c.type);
            Console.WriteLine("Sound: " + c.makeSound());
            Console.Read();
        }
    }
}