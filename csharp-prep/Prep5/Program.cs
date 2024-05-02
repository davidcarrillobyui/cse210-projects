using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Welcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptFavoriteNumber();
        int squareNumber = SquareNumber(favoriteNumber);
        ShowResult(userName, squareNumber);
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptFavoriteNumber()
    {
        Console.Write("Type your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void ShowResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }



   
}