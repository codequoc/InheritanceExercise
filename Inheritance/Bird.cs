using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public bool canFly { get; set; }
        public string featherTypes { get; set; }
        public int flyDistances { get; set; }
        public string beakType { get; set; }
    }
}
