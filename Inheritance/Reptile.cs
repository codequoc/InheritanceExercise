using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }
        public string heatSource { get; set; }
        public string scaleType { get; set; }
        public int eggs { get; set; }
        public bool parentalCare { get; set; }


    }
}
