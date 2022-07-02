using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Dice
    {
        /// <summary>
        /// maximum value variable that the dice can take
        /// </summary>
        int maximumDiceValue;

        Random random = new Random();

        /// <summary>
        /// enter the maximum value the dice can take
        /// </summary>
        /// <param name="maximumDiceValue"></param>
        public Dice(int maximumDiceValue)
        {
            this.maximumDiceValue = maximumDiceValue;
        }
        /// <summary>
        /// roll a dice for a random number
        /// </summary>
        /// <returns></returns>
        public int rollTheDice()
        {
            return random.Next(1, maximumDiceValue + 1);
        }
    }
}