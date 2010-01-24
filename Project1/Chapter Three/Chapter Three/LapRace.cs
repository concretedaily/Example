using System;

namespace Lap_Race
{
    static class LapRace
    {
        /// <summary>
        /// This is my Chapter Three Program.
        /// Steve Schnabel, 12.7.09
        /// </summary>
        static void Main(string[] args)
        {
            // assign integar spaces
            int lapNum;
            int lap;

            // create your random num gen
            Random generator = new Random();

            //this for loop tells it to set your sentry point to the num 1, then counter lap until it writes to the Console 11 times
            for (lap = 1; lap <= 10; lap++)
            {

                //this if statement tells it to gen a new random number until the for statement is done so you don't end up with 10 laps having the same lap time
                if (lap != 11)
                {
                    lapNum = (int)(generator.NextDouble() * 10) + 1;
                    Console.WriteLine("Lap #: {0}" + " has a laptime of {1} minutes", lap, lapNum);
                }

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
