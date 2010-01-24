using System;

namespace ConCat
{
    /// <summary>
    /// Demonstrates string concatenation.
    /// </summary>
    /// 
    class concat
    {
        static void Main(string[] args)
        {
            string userName = "Steve";
            Console.WriteLine("This is regular text");
            Console.WriteLine("Hi there, " + userName + "!");
            Console.WriteLine("This line has a \t tab in it");
            Console.WriteLine("This line has a \n newline in it");
            Console.WriteLine("This line has a \\ slash in it");
            Console.WriteLine("This line has \"quotes\" in it");
            Console.WriteLine();
            Console.ReadLine();
         } //end main
    } //end class
} //end namespace


