using System;

namespace adventure
{
    /// <summary>
    /// Text adventure game
    /// User responds to some questions, and these
    /// responses are used to write a story
    /// Steve Schnabel, 11.27.09
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string person;
            string occupation;
            string seaCreature;
            string animal;
            string friend;
            string tool;
            string problem;
            string gender;
            
            Console.WriteLine("Steve's Adventure Game");
            Console.Write("What's your name? ");
            person = Console.ReadLine();

            Console.Write("What's your gender (m/f)? ");
            gender = Console.ReadLine();

            Console.Write("What is your occupation? ");
            occupation = Console.ReadLine();

            Console.Write("Please tell me your favorite animal: ");
            animal = Console.ReadLine();

            Console.Write("What is the name of one of your friends? ");
            friend = Console.ReadLine();

            Console.Write("Name a problem you might face: ");
            problem = Console.ReadLine();

            Console.Write("Name a tool: ");
            tool = Console.ReadLine();

            Console.Write("Please give me the name of a sea creature: ");
            seaCreature = Console.ReadLine();

            //create some blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Write the story
            Console.WriteLine("One day there was a person named {0}.  Now, {0} was usually ", person);
            Console.WriteLine("very content to work as a {0}, but sometimes the job ", occupation);
            Console.WriteLine("was extremely difficult.");
            Console.WriteLine("One day, {0} discovered that the heartbreak of {1} had ", person, problem);
            Console.WriteLine("occured just one time too often.  \"I can't stand being a ");

            if (gender == "m")
            {
                Console.WriteLine("{0} anymore!\" yelled {1}, as he hurled away the ", occupation, person);
            }
            else 
            {
                Console.WriteLine("{0} anymore!\" yelled {1}, as she hurled away the ", occupation, person);
            }
            
            Console.WriteLine("{0} in anger.  No {1} will keep me from fulfilling ", tool, problem);
            Console.WriteLine("my dreams!!  What I really want, said {0}, is to be just like ", person);
            Console.WriteLine("{0}.  Now that's somebody to admire.  So {1} put away the ", friend, person);
            Console.WriteLine("{0} forever, and followed {1} into the pastoral ", tool, friend);
            Console.WriteLine("world of {0}-ranching.  Eventually, {1} was able to ", animal, person);
            Console.WriteLine("retire, as happy as a {0}.", seaCreature);

            //create some blank lines
            Console.WriteLine();
            Console.WriteLine();
            //ask for Enter to quit
            Console.WriteLine("Press \"Enter Key\" to exit game");
            Console.ReadLine();

        } //end main
    } //end class
} //end the namespace

