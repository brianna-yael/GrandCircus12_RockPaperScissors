using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player //store a name and a Roshambo value
    {
        //defining the class (Player) variables
        protected string name; //string variable that only the children of Player can access
        protected Roshambo rpsList; //list rps that only the children of Player can access 

        public Player(Roshambo g) //the constructor is named Player and its parameter is a value from the
        //Roshambo class that it stores in the rpslist variable
        {
            rpsList = g;
        }

        public string GetName() //getter that returns a name
        {
            return name;
        }

        public abstract string GenerateRoshambo(); //method stub that allows the children of Player to 
        //generate and return a Roshambo value
    }
}
