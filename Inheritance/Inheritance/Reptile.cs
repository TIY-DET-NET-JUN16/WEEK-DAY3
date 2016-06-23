using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public int AvgWeight { get; set; }

        public Reptile()
        {
            GivesLiveBirth = false;
        }
    }
}
