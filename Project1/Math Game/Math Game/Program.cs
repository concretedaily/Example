using System;
namespace CoinToss
{
    class Game
    {
        /// <summary>
        /// Trying different stuff with the random num gen, casting and converts 
        /// </summary>
        static void Main(string[] args)
		{
//Gets the player name and the coin toss pick - hey look I used a cast method..sweet!!
		string player;
		int myInt, myInt2;
        Console.WriteLine("Welcome to my game, I call it The Coin Toss, ");
        Console.Write("enter your name to get started: ");
		player = Console.ReadLine();
		Console.WriteLine("Hello {0}", player + ", pick heads or ");
        Console.WriteLine("tails by typing a  \"1\" for Heads or a \"2\" for Tails:");
		myInt = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("\n .");
		Console.WriteLine("\n .");
		Console.WriteLine("\n .");
//Random num generator to assign the die roll 
		Random generator = new Random();
		myInt2 = (int)(generator.NextDouble() * 2) + 1;
		Console.WriteLine("{0}", myInt2);
		if (myInt == myInt2) {
//My switch statement
		switch (myInt)
		{
			case 1:		
		  	   Console.WriteLine("You are lucky!  Heads it is!!");
			Console.WriteLine();
			   break;
			case 2:
			   Console.WriteLine("You are lucky!  Tails it is!!");
			Console.WriteLine();
			   break;
             //
             //I got an error with this statement so I am commenting it out for now.
             //default: 
			 // Console.WriteLine("Hey, something went wrong, fix your shit!!");
             //
			Console.WriteLine();
		} 
		} else {
			Console.WriteLine("Your luck has run out...you got it wrong!!");
			Console.WriteLine();
 		         }  	      	
//Next part of the game is simple math equations			
		            int a, b, c, guess, score;
			score = 0;
		Random roller = new Random();
			a = (int)(roller.NextDouble() * 10) + 1;
			b = (int)(roller.NextDouble() * 10) + 1;
			c = a + b;
              	Console.WriteLine("Now that we tested your luck, ");
                Console.WriteLine("let's test your basic math skills.");
		        Console.WriteLine("Here are some simple problems to solve.");
//Addition 
	            Console.WriteLine("What is {0} + {1} ?", a , b);
		guess = Convert.ToInt32(Console.ReadLine());
		if (guess == c) {
	 	  score++;
		}
 //Subtraction
		a = (int)(roller.NextDouble() * 10) + 1;
		b = (int)(roller.NextDouble() * 10) + 1;
		c = a + b;
		Console.WriteLine("What is {0} - {1} ?", c , a);
		guess = Convert.ToInt32(Console.ReadLine());
		if (guess == b) {
	 	 score++;
		}		
//Multiplication		
		a = (int)(roller.NextDouble() * 10) + 1;
		b = (int)(roller.NextDouble() * 10) + 1;
		c = a * b;
		Console.WriteLine("What is {0} * {1} ?", a , b);
		guess = Convert.ToInt32(Console.ReadLine());
		if (guess == c) {
	 	 score++;
		}
//Division		
		a = (int)(roller.NextDouble() * 10) + 1;
		b = (int)(roller.NextDouble() * 10) + 1;
		c = a * b;
		Console.WriteLine("What is {0} / {1} ?", c , a);
		guess = Convert.ToInt32(Console.ReadLine());
		if (guess == b) {
	 	 score++;
		}
//Checking the Answers
		Console.WriteLine("Let's see how you did..");
        Console.WriteLine("your score is: {0} out of 4", score);
		if (score <= 2) {
		Console.WriteLine("Maybe you were good at gym class in school, cuz you suck at math.");
		} else {		
		Console.WriteLine("You did good, time to move on to the next part of the game.");
		Console.WriteLine();
		}
//The Role-Playing Game
int choice; 
int myInt3;
Random generator1 = new Random();

Console.WriteLine("We all luv our role-playing games.  ");
Console.WriteLine("This will simply allow you pick your favorite sided ");
Console.WriteLine("die and then spit out a number within that range."); 
Console.WriteLine("Go ahead...tell me your favorite sided die.  ");
Console.WriteLine("Your choices are: 4, 6, 8, 10, 12 & 20");

choice = Convert.ToInt32(Console.ReadLine());
myInt3 = (int)(generator1.NextDouble() * choice + 1);

Console.WriteLine("You rolled a {0}", myInt3);
//The End
Console.WriteLine("Well that's it..hope you like my game...if not, ");
Console.WriteLine("what do you expect for only being on Chapter 2?");
Console.WriteLine("Hit \"Enter\" to quit.");
Console.ReadLine();
} //end method
    } //end class
} //end namespace



