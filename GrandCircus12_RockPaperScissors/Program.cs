using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Roshambo rps = new Roshambo(); //Roshambo object rps
                DwayneJohnson ro = new DwayneJohnson(rps); //Dwayne Johnson object ro
                GrantThompson ra = new GrantThompson(rps); //Grant Thompson object ra
                UserPlayer uc = new UserPlayer(rps); //User object uc 
                RoshamboApp op = new RoshamboApp();
                Console.WriteLine("Welcome to Rock, Paper, Scissors! Enter your name:");
                string userName = Console.ReadLine();
                Console.WriteLine("Thanks {0}! Would you like to play against {1} or {2} (DJ/GT)?", userName, ro.GetName(), ra.GetName());
                string userOpponent = op.OpponentName();
                Console.WriteLine("Your opponent is {0}. Rock, paper, or scissors (R/P/S)?", userOpponent);
                Console.WriteLine(userName + ": " + uc.GenerateRoshambo());
                if (userOpponent == "Dwayne Johnson")
                {
                    Console.WriteLine(ro.GetName() + ": " + ro.GenerateRoshambo()); //generate Roshambo using the method defined in the Dwayne Johnson class
                }
                if (userOpponent == "Grant Thompson")
                {
                    Console.WriteLine(ra.GetName() + ": " + ra.GenerateRoshambo()); //generate Roshambo using the method defined in the Grant Thompson class
                }
                repeat = DoAgain();
            }
            Console.WriteLine("Thanks for playing! Goodbye.");
        }

        public static bool DoAgain()
        {
            Console.WriteLine("Would you like to play again? ('y' or 'n')");
            string response = Console.ReadLine();
            response = response.ToLower();
            bool newStudent;
            if (response == "y")
            {
                newStudent = true;
            }
            else if (response == "n")
            {
                newStudent = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                newStudent = DoAgain();
            }
            return newStudent;
        }
    }
}
