using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        List<int> numbers = new List<int>();
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber > 0)
            {
                numbers.Add(userNumber);
            } 
        }

        // Getting the sum of numbers inside the list
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        // Making sure the list is not empty    
        if (numbers.Count > 0) 
        {
            int max = numbers[0];

            //Finding the max|largest number of the list with a loop
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    // if this number is greater than the max, we have found the new max!
                    max = number;
                }
            }

            // //Another way of finding the largest number sorting the list
            numbers.Sort();
            // //Because the list is sorted in a default ascending sort, the last element is the highest
            // max = numbers[^1];

            Console.WriteLine($"The largest number is: {max}");

            // Finding the average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average:F2}");

            // Stretch 2. Printing the sorted list
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.Write(number + " "); 
            }
        }

        else
        {
            Console.WriteLine("The list is empty.");
        }

    }
}