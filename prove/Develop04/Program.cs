using System;

class Program
{
    static void Main(string[] args)
    {
       while(true)
       {
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine("1.Breathing Activity");
        Console.WriteLine("2.Reflection Activity");
        Console.WriteLine("3.Listing Activity");
        Console.WriteLine("4.Exit");

        string choice = console.ReadLine();

        switch (choice)
        {
            case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

            
            default:
        }


        
       }
    }
}