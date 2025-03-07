using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? "); when the user was choosing the magic number
        // int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userGuess = -1;

        while(userGuess != magicNumber)
        {
            Console.Write("Guess the magic number: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}