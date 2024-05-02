using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Display a greeting message
        Console.WriteLine("Hello Prep5 World!");

        // Call the Welcome function to display a welcome message
        Welcome();

        // Prompt the user for their name and store it in a variable
        string userName = PromptUserName();

        // Prompt the user for their favorite number and store it in a variable
        int favoriteNumber = PromptFavoriteNumber();

        // Calculate the square of the favorite number
        int squareNumber = SquareNumber(favoriteNumber);

        // Display the result, passing the user's name and the square of their favorite number
        ShowResult(userName, squareNumber);
    }

    // Function to display a welcome message
    static void Welcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to prompt the user for their favorite number and return it
    static int PromptFavoriteNumber()
    {
        Console.Write("Type your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function to calculate the square of a given number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Function to display the result, taking the user's name and the square of their favorite number as input
    static void ShowResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }
}
