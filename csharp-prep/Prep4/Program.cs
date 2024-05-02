using System;
using System.Collections.Generic;

/*
1.Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
2.Compute the sum, or total, of the numbers in the list.
*/

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while(true)
        {
            Console.Write("Enter a number (Enter 0 to stop): ");
            int input = int.Parse(Console.ReadLine());

            if(input==0)
            {
                break;
            }

            numbers.Add(input);
        }

        int sum = 0;

        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}