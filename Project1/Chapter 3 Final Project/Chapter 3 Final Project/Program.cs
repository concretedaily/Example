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


=======
using System;

namespace CHAP_3_END_PROJ
{
    static class SKULL_AND_BONES
    {
        /// <summary>
        /// The main entry point for the application.
        /// Steve, Schnabel 12.07.09
        /// </summary>
        static void Main(string[] args)
        {
//Setting up my variables
            
            string gameOption = "";
            while (gameOption != "quit") {

            Console.WriteLine("Welcome to my Chapter Three Game");
            Console.WriteLine("Enter the # of the game you want to play, or type \"quit\" to exit:");
            Console.WriteLine("1 Elmer Fudd");
            Console.WriteLine("2 Monty Python");
            Console.WriteLine();
	    Console.WriteLine();
            Console.Write("-> "); 
           
            gameOption = Console.ReadLine();
                       
           switch (gameOption){
               case "1":

                   string pigWord = "";
                   string sentence = "";
                   string targetLetters = "Rr";
                   int letterPos;

                   Console.WriteLine();
                   Console.WriteLine("Now let's have fun with a version of the Pig Latin program...");
                   Console.WriteLine("It's rabbit hunting season and Elmer Fudd has his \"Peace Keeper\" ");
                   Console.WriteLine("pointed at Bugs Bunny!!");
                   Console.WriteLine();
                   Console.WriteLine("Enter any sentence for Elmer to say to Buggs");
                   Console.WriteLine("before he blasts him to smithereenes.");
                   Console.WriteLine();

                   sentence = Console.ReadLine();
           

                //dividing the phrase into words
                foreach (string word in sentence.Split())
                {

                    letterPos = targetLetters.IndexOf(word);
                    if (letterPos == 1)
                    {
                        //there's no r's
                        pigWord = word.ToLower();
                        Console.Write("{0} ", pigWord);  
                    } else {
                        pigWord = word.ToLower();
                        Console.Write("{0} ", pigWord.Replace("r", "w"));
                          }               
                    }
                break;

               case "2":
                
                   string name;
                   string quest;
                   string color;
                
                Console.WriteLine();
                Console.WriteLine("\"STOP!!!\", shouts an old man standing in front of a bridge.");
                Console.WriteLine("Who would cross The Bridge of Death must answer me");
                Console.WriteLine("these questions three.  Threre the other side he see!");
                Console.WriteLine();

                Console.Write("What is your name?: ");
                name = Console.ReadLine();

                Console.WriteLine("What is your quest?: ");
                quest = Console.ReadLine();
                   
                if (quest != "to seek the holy grail")
                   Console.WriteLine("The old man laughes as you are plucked outta the sky");
                   Console.WriteLine("by some unseen force, and tossed into a void of endless mist!!");
                   Console.WriteLine("HINT: Go watch the Holy Grail and then come back and try again");
                   Console.WriteLine();
                   Console.WriteLine();
                   Console.WriteLine("Enter the # of the game you want to play, or type \"quit\" to exit:");
                   Console.WriteLine("1 Elmer Fudd");
                   Console.WriteLine("2 Monty Python");
                   Console.WriteLine("3 Picture");
                   Console.WriteLine();
                   Console.Write("-> "); 
                   gameOption = Console.ReadLine();


           } if (quest = "to seek the holy grail")
           {

               Console.WriteLine("What is your favorite color?: ");
               color = Console.ReadLine();
           }
           else
           {
               Console.WriteLine("The old man seems satisfied with your answer and chirps, \"Right, off you go\"");
               Console.WriteLine();
               Console.WriteLine("You've seen way too much Monty Python or your memory is like a steel trap..good job.");
               Console.WriteLine("Since you passed the Bridge of Death..you get the prize..check it");
           }
                   break;

                   {
                   }
            }

            {
   
            }
            {
              
            }


        }
    }
}

>>>>>>> 7d6b9594c3906e2db39fbde4e31b4809aed0cdc6
