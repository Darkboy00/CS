using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Birds
    {
        public string type;
        public int speed;
        public double weight;

        public virtual string makeSound()
        {
            return "sound";
        }
    }
}