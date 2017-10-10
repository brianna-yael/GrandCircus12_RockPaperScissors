using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RoshamboApp
    {
        public RoshamboApp()
        {

        }

        public string OpponentName()
        {
            string userInputTwo = Console.ReadLine();
            userInputTwo = userInputTwo.ToLower();
            string dj = "Dwayne Johnson";
            string gt = "Grant Thompson";
            string userOpponent = string.Empty;
            if (userInputTwo != "dj" && userInputTwo != "gt")
            {
                Console.WriteLine("I don't understand that, let's try again");
                userOpponent = OpponentName();
            }
            if (userInputTwo == "dj")
            {
                userOpponent = dj;
            }
            if (userInputTwo == "gt")
            {
                userOpponent = gt;
            }
            return userOpponent;
        }
    }
}
