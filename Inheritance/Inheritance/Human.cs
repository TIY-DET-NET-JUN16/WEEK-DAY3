using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Human : Mamal
    {
        public override int AvgNumOffsring { get; set; }

        public Human()
        {
            AvgNumOffsring = 1;
        }

        public string HairColor { get; set; }

        public override int NumberOfLegs()
        {
            return 2;
        }

        public override int NumberOfTails()
        {
            return 0;
        }
    }
}
