using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Human fred = new Human();
            fred.HairColor = "Brown";
            fred.Species = "Homo Erectus";
            Console.WriteLine("Fred is a {0} with {1} legs. Fred is of the species {2}.",
                fred.GetType(), fred.NumberOfLegs(), fred.Species);
            Console.WriteLine("Fred's average number of offspring is {0}. Fred has {1} tails.",
                fred.AvgNumOffsring, fred.NumberOfTails());
            Console.WriteLine("It is {0} that Fred's species gives live birth",
                fred.GivesLiveBirth.ToString().ToLower());

            Console.ReadKey();
        }
    }
}
