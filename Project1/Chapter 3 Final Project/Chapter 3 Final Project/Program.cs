using System;

namespace CHAP_3_END_PROJ
{
    static class SKULL_AND_BONES
    {
		private static void ElmerFudd() {
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
		}
		
		private static void GrailWin() {
			Console.WriteLine("The old man seems satisfied with your answer and chirps, \"Right, off you go\"");
			Console.WriteLine();
			Console.WriteLine("You've seen way too much Monty Python or your memory is like a steel trap..good job.");
			Console.WriteLine("Since you passed the Bridge of Death..you get the prize..check it");
		}
		
		private static void GrailFail() {
			Console.WriteLine("The old man laughes as you are plucked outta the sky");
			Console.WriteLine("by some unseen force, and tossed into a void of endless mist!!");
			Console.WriteLine("HINT: Go watch the Holy Grail and then come back and try again");
			Console.WriteLine();
		}
		
		private static void MontyPython() {
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
			   
			if (quest != "to seek the holy grail") {
				GrailFail();
				return;
			} else if (quest = "to seek the holy grail") {
				Console.WriteLine("What is your favorite color?: ");
				color = Console.ReadLine();
				if(color.ToLower().Equals("blue")) {
					//TODO: Generate random value. If value > some preset kill them, else say correct.
					GrailWin();
				} else {
					GrailFail();
				}
			} else {
				GrailWin();
			}
		}
		
        /// <summary>
        /// The main entry point for the application.
        /// Steve, Schnabel 12.07.09
        /// </summary>
        public static void Main(string[] args) {
			//Setting up my variables
			string gameOption = "";
			while (gameOption != "quit") {
	            Console.WriteLine("Welcome to my Chapter Three Game");
	            Console.WriteLine("Enter the # of the game you want to play, or type \"quit\" to exit:");
	            Console.WriteLine("1 Elmer Fudd");
	            Console.WriteLine("2 Monty Python");
	            Console.WriteLine();
	            Console.Write("-> "); 
	           
	            gameOption = Console.ReadLine();
	                       
				switch (gameOption) {
				   case "1":
						ElmerFudd();
						break;
				
				   case "2":
				    	MontyPython();
						break;
				}
			}
    	}
	}
}

