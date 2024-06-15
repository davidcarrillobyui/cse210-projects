// Derived class representing the breathing activity
public class BreathingActivity : Activity
{
    // Constructor that calls the base class constructor with name and description
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Override the Run method to implement the breathing activity
    public override void Run()
    {
        Start(); // Call the Start method from the base class
        for (int i = 0; i < Duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Pause(2); // Pause for 2 seconds
            Console.WriteLine("Breathe out...");
            Pause(2); // Pause for 2 seconds
        }
        End(); // Call the End method from the base class
    }
}
