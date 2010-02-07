<<<<<<< HEAD
using System;

namespace CHAP_3_END_PROJ
{
    static class SKULL_AND_BONES_2
    {
        /// <summary>
        /// The main entry point for the application.
        /// Steve, Schnabel 12.07.09
        /// </summary>
        static void Main(string[] args)
        {
            //Setting up my variables

            string response = "";

            Console.WriteLine("Welcome to my Chapter Three Game");
            Console.WriteLine("Enter the # of the game you want to play, or type \"3\" to quit:");
            Console.WriteLine("1 Elmer Fudd");
            Console.WriteLine("2 Coin Toss");
            Console.WriteLine("3 Quit");
            Console.WriteLine();
            Console.Write("-->: ");

            response = Console.ReadLine();

            while (response != "3")
            {
                if (response == "1")
                {
                    //switch (response){
                    //  case "1":
                    string pigWord = "";
                    string sentence = "";

                    Console.WriteLine();
                    Console.WriteLine("Now let's have fun with a version of the Pig Latin program...");
                    Console.WriteLine("It's rabbit hunting season and Elmer Fudd has his \"Peace Keeper\" ");
                    Console.WriteLine("pointed at Bugs Bunny!!");
                    Console.WriteLine();
                    Console.WriteLine("Enter any sentence for Elmer to say to Buggs,");
                    Console.WriteLine("before he blasts him to smithereenes.");
                    Console.WriteLine();

                    sentence = Console.ReadLine();
                    pigWord = sentence.ToLower();

                    Console.WriteLine();
                    Console.WriteLine("{0}", pigWord.Replace("r", "w"));
                    Console.WriteLine();
                    Console.WriteLine("Enter the # of the game you want to play, or type \"3\" to quit:");
                    Console.WriteLine("1 Elmer Fudd");
                    Console.WriteLine("2 Coin Toss");
                    Console.WriteLine("3 Quit");
                    Console.WriteLine();
                    Console.Write("-->: ");

                    response = Console.ReadLine();
                } if (response == "2")
                {
                    string player;
                    int myInt, myInt2;

                    Console.WriteLine("Welcome to the Coin Toss, ");
                    Console.Write("enter your name to get started: ");

                    player = Console.ReadLine();
                    Console.WriteLine("Hello {0}", player + ", pick heads or ");
                    Console.WriteLine("tails by typing a  \"1\" for Heads or a \"2\" for Tails:");

                    myInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine(".");

                    //Random num generator to assign the die roll 
                    Random generator = new Random();
                    myInt2 = (int)(generator.NextDouble() * 2) + 1;
                    Console.WriteLine("{0}", myInt2);

                    if (myInt == myInt2)
                    {
                       Console.WriteLine("Good Guess!!");
                       Console.WriteLine();
                       Console.WriteLine("Enter the # of the game you want to play, or type \"3\" to quit:");
                       Console.WriteLine("1 Elmer Fudd");
                       Console.WriteLine("2 Coin Toss");
                       Console.WriteLine("3 Quit");
                       Console.WriteLine();
                       Console.Write("-->: ");
                       response = Console.ReadLine();
                    } else {
                        Console.WriteLine("Your luck has run out...you got it wrong!!");
                        Console.WriteLine();
                        Console.WriteLine("Enter the # of the game you want to play, or type \"3\" to quit:");
                                Console.WriteLine("1 Elmer Fudd");
                                Console.WriteLine("2 Coin Toss");
                                Console.WriteLine("3 Quit");
                                Console.WriteLine();
                                Console.Write("-->: ");
                                response = Console.ReadLine();
                        }


                    }
                }
            }
        }
    }