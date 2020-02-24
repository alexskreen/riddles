using System;

class Riddles
{
    static void Main()
    {
        Console.WriteLine("What kind of goose fights with snakes?");
        string userInput1 = Console.ReadLine().ToLower();

        if (userInput1.Contains("mongoose"))
        {
            Console.WriteLine("Correct!");
            
            Console.WriteLine("I am wet when drying. What am I?");
            string userInput2 = Console.ReadLine().ToLower();
            
            if (userInput2.Contains("towel"))
            {
                Console.WriteLine("Correct!");

                Console.WriteLine("What word is always pronounced wrong?");
                string userInput3 = Console.ReadLine().ToLower();
            
                if (userInput3.Contains("wrong"))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("You've been eaten by the Sphinx!");
                }
            }
            else
            {
                Console.WriteLine("You've been eaten by the Sphinx!");
            }
        }
        else
        {
            Console.WriteLine("You've been eaten by the Sphinx!");
        }
    }
}