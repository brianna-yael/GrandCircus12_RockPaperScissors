using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Roshambo
    {
        //defining the class (Roshambo) variables
        List<string> rps = new List<string>(); //create a string list named rps. rps is the list.

        public Roshambo() //the constructor is named Roshambo, and it adds three variables to the rps list
        {
            rps.Add("rock");
            rps.Add("paper");
            rps.Add("scissors");
        }

        public string GetByString()
        //this method uses a string input to check the user input value, and stores it in one of the three variables
        //in the rps list if it is the desired value. If it is not the correct value, it returns a -1
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            string selection = string.Empty;
            if (input == "r")
            {
                return rps[0];
            }
            if (input == "p")
            {
                return rps[1];
            }
            if (input == "s")
            {
                return rps[2];
            }
            Console.WriteLine("That was not a valid selection. Please select either rock, paper, or scissors (R/P/S?)");
            return GetByString();
        }

        public string GetByIndex(int i)
        {
            string output;
            try
            {
                output = rps[i];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("That was not a valid index put into the rps list");
                output = "-1";
            }

            return output;
        }
    }
}
