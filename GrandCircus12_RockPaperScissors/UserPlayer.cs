using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class UserPlayer : Player //inherit the player class and implement the GenerateRoshambo() to return any value
    {
        public UserPlayer(Roshambo g) : base(g) //the constructor is Dwayne Johnson and it takes
        //the value r in the Roshambo class, and stores it in the player varialble rpslist?
        {
            name = "You";
        }

        public override string GenerateRoshambo() //uses the method stub provided by Player to ask for 
        //the users input to always be returned when User Player is called
        {
            string userChoice = rpsList.GetByString(); //calls on the Roshambo class method run the user input and output the correct string from the rps list
            return userChoice;
        }
    }
}
