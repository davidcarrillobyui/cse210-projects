using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        int magicNumber=int.Parse(Console.ReadLine());*/

        int magicNumber= new Random().Next(1, 101);
        int userGuess= 0;

        while (userGuess != magicNumber)
        {
            Console.Write("Make a guess: " );
            userGuess=int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else if (userGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Lower.");
            }
        }

        
    }
}