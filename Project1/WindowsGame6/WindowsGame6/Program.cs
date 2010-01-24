using System;

namespace Chapter_Three
{
    static class DiceGame
    {
        /// <summary>
        /// This is my Chapter Three Program.
        /// Steve Schnabel, 12.7.09
        /// </summary>
        static void Main(string[] args)
        {
            string player;
            int diePick;
            int roll;
            int timesRolled;
            float sum = 0.0f;
            float average = 0.0f;
                                    
            //asks for the player to pick a number and converts their answer from a string variable to an integar
            Console.Write("Hello there, please enter your name to get started: ");
            player = Console.ReadLine();
            Console.Write("\n Okay {0}" + ", let's begin by telling me how many 6-sided dice to roll?: ", player);
            diePick = Convert.ToInt32(Console.ReadLine());

            //create a random num for the amount of the 6-sided dice to roll; give the sum and the average numbers
            
            Random generator = new Random();
          
            //Display each die roll

           for (timesRolled = 1; timesRolled <= diePick; timesRolled++)
           {
                   roll = (int)(generator.NextDouble() * 6) + 1;
                   sum += roll;
                   average = sum / diePick;
             Console.WriteLine("You cast the die... {0}", roll);
            }
  
            Console.WriteLine("The sum of your dice rolled is {0}", sum);
            Console.WriteLine("The average of your dice rolled is {0}", average);
            Console.WriteLine();
            Console.ReadLine();
        
        }
    }
}

