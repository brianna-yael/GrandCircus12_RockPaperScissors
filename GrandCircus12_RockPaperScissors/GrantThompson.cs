using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors //Randomly select rock, paper, or scissors
{
    class GrantThompson : Player
    {
        public GrantThompson(Roshambo g) : base(g) //the constructor is Grant Thompson and it takes
        //the value g in the Roshambo class, and stores it in the player varialble rpslist?
        {
            name = "Grant Thompson";
        }

        public override string GenerateRoshambo() //uses the method stub provided by Player to ask for 
        //a random selection to always be returned when Grant Thompson is called
        {
            int i = 0;
            Random randomKing = new Random();
            i = randomKing.Next(0, 3);
            string randomChoice = rpsList.GetByIndex(i);
            return randomChoice;
        }
    }
}
