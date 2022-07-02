using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(8);
            Console.WriteLine("dice: " + dice.rollTheDice());
            Console.Read();
        }
    }
}