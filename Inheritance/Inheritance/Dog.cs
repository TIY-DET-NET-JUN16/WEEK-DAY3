using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog : Mamal
    {
        public override int AvgNumOffsring { get; set; }

        public Dog()
        {
            AvgNumOffsring = 5;
        }

        public string Breed { get; set; }
    }
}
