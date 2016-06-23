using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Snake : Reptile
    {
        public bool IsVenomous { get; set; }

        public override int NumberOfLegs()
        {
            return 0;
        }
    }
}
