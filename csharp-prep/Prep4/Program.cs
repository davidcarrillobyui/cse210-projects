using System;
using System.Collections.Generic;

/*
1.Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
2.Compute the sum, or total, of the numbers in the list.
3.Compute the average of the numbers in the list.
*/

class Program
{
    static void Main(string[] args)
    {
        // Create a new list to store the numbers entered by the user
        List<int> numbers = new List<int>();

        // Continuously prompt the user for numbers until they enter 0
        while(true)
        {
            // Ask the user to enter a number
            Console.Write("Enter a number (Enter 0 to stop): ");
            // Read the input from the user and convert it to an integer
            int input = int.Parse(Console.ReadLine());

            // Check if the input is 0, indicating the end of input
            if(input == 0)
            {
                // Exit the loop if the input is 0
                break;
            }

            // Add the entered number to the list
            numbers.Add(input);
        }

        // Initialize a variable to store the sum of the numbers
        int sum = 0;

        // Iterate through each number in the list and add it to the sum
        foreach(int number in numbers)
        {
            sum += number;
        }

        // Output the sum of the numbers to the console
        Console.WriteLine("The sum of the numbers is: " + sum);

        // Calculate the average of the numbers by dividing the sum by the total count of numbers
        float average = ((float)sum / numbers.Count);
        // Output the average to the console
        Console.WriteLine($"The average is: {average}");
        
    }
}