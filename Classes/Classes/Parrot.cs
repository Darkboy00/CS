using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Parrot:Birds
    {
        public string name;
        public string color;

        public override string makeSound()
        {
            return "cik cik";
        }
    }
}