using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calls the function throwdice three times with different parameters 
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");
            //Keeps the window open
            Console.ReadKey();
        }
        //Delcares a function called ThrowDice and has a string parameter called diceString
        static void ThrowDice(string diceString)
        {
            //the console prints out "throwing: " plus the parameter on a single line
            Console.WriteLine("Throwing: " + diceString);
            //the console prints out "results: " on a single line
            Console.WriteLine("Results: ");
            //declares a variable called diceStat that is the parameter gone through a split of "d"
            var diceStat = diceString.Split('d');
            //declares a variable called diceNum that converts the first part of the diceStat to a number
            var diceNum = Convert.ToInt32(diceStat[0]);
            //declares a variable called diceSide that converts the second part of the diceStat to number 
            var diceSide = Convert.ToInt32(diceStat[1]);
            //declares a variable called randomVal that takes two parameters and finds a random number between them 
            var randomVal = new Random();
            //a loop is created that starts at one, then continues until it reaches the value of diceNum, and increases by one everytime
            for(var i = 1; i <= diceNum; i++)
            {
                //declares a variable called calcSide which uses randomVal to find a number
                var calcSide = randomVal.Next(1, diceSide + 1);
                //prints calcSide plus a space
                Console.Write(calcSide+ " ");
            }
            //prints a space
            Console.WriteLine(" ");



        }
    }
}

