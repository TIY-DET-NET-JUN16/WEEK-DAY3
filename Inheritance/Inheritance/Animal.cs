using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IAnimal
    {
        string Species { get; set; }

        bool GivesLiveBirth { get; set; }

        int NumLegs();

        int NumberOfTails();
    }
}
