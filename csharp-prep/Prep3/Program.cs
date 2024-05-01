using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber=int.Parse(Console.ReadLine());
        Console.Write("Make a guess: " );
        int userGuess=int.Parse(Console.ReadLine());

        if (userGuess < magicNumber)
        {
            Console.Write("Higher.");
        }
        else if (userGuess == magicNumber)
        {
            Console.Write("You guessed it!");
        }
        else
        {
            Console.Write("Lower.");
        }
    }
}