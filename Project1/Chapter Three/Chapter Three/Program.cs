using System;

namespace Chapter_Three
{
    static class LapRace
    {
        /// <summary>
        /// This is my Chapter Three Program.
        /// Steve Schnabel, 12.7.09
        /// </summary>
        static void Main(string[] args)
        {
            int lapNum; 
            int lap;
            
                Random generator = new Random();
              //  lapNum = (int)(generator.NextDouble() * 10) + 1;

            for (lap = 1; lap <= 10; lap++){
                if (lap != 11)
                {
                    lapNum = (int)(generator.NextDouble() * 10) + 1;
                    Console.WriteLine("Lap #: {0}" + " has a laptime of {1} minutes", lap, lapNum);
                }
                else
                    Console.WriteLine();
            } //end for statement
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

