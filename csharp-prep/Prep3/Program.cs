using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        int magicNumber=int.Parse(Console.ReadLine());*/

        bool playAgain= true;

        while(playAgain)
        {
            int magicNumber= new Random().Next(1, 101);
            int userGuess= 0;
            int gessCount=0;

            while (userGuess != magicNumber)
            {
                Console.Write("Make a guess: " );
                userGuess=int.Parse(Console.ReadLine());
                gessCount++;

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

            Console.WriteLine($"It took you {gessCount} guesses");

            Console.Write("Do you want to play again? (yes/no): ");

            string playAgainResponse= Console.ReadLine().ToLower();

            if (playAgainResponse != "yes")
            {
                playAgain = false;
            }

        }
        
    }
}