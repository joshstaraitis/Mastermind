using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Mastermind Start");
            Console.WriteLine("Game Rules:");
            Console.WriteLine("\nI have generated a random 4 digit code with each digit being a number between 1 and 6.");
            Console.WriteLine("\nAfter each guess, I will give you a 4-digit response:");
            Console.WriteLine("\n(-) is printed for every digit that is correct but in wrong position. ");
            Console.WriteLine("\n(+) is printed for every digit that is correct and in the correct position.");
            Console.WriteLine("\nAfter each guess, I will give you a 4-digit response:");
            Console.WriteLine("\nAfter 10 attempts, the game will end");
            Console.WriteLine("\nEnter first guess: ");

           var game = new Game();

            do
            {
                var attempt = Console.ReadLine();
                Console.WriteLine(game.Attempt(attempt));
            }
            while (!game.Finished);
        }
    }
}
