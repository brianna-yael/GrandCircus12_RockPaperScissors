using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors //Always select rock
{
    class DwayneJohnson : Player
    {
        public DwayneJohnson(Roshambo g) : base(g) //the constructor is Dwayne Johnson and it takes
        //the value r in the Roshambo class, and stores it in the player varialble rpslist?
        {
            name = "Dwayne Johnson";
        }

        public override string GenerateRoshambo() //uses the method stub provided by Player to ask for 
        //rock to always be returned when Dwayne Johnson is called
        {
            return rpsList.GetByIndex(0);
        }
    }
}
