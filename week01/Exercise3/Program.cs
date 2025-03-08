using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? "); when the user was choosing the magic number
        // int magicNumber = int.Parse(Console.ReadLine());
        int userGuess = -1;
        string response = "yes";
        int numberOfGuesses = 1;
        do
        {   
            // Initialize the random number 
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            Console.WriteLine(magicNumber);
            // Start the guessing game
            while(userGuess != magicNumber)
            {
                Console.Write("Guess the magic number: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    numberOfGuesses += 1;
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    numberOfGuesses += 1;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {numberOfGuesses} attempts.");
                    //Restart the counter to prepare if the user wants to play again
                    numberOfGuesses = 1; 
                    // Ask if the user wants to play again
                    Console.Write("Do you want to play again? (yes or no) ");
                    response = Console.ReadLine().ToLower();
                }
            }
        }while(response=="yes");
        Console.WriteLine("Thank you, have a great day!");
    }
}