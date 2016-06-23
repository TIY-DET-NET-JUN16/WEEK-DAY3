using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Mamal : IAnimal
    {
        //public abstract int AvgNumOffsring { get; set; }

        //public override string Species { get; set; }

        public bool GivesLiveBirth { get; set; }

        public string Species { get; set; }

        public Mamal()
        {
            GivesLiveBirth = true;
        }

        public abstract int NumLegs();
        public abstract int NumberOfTails();
    }
}
