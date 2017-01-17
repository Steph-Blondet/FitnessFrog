using System; //declaring it here so we can stop writing "System" everytime.

namespace Treehouse.Fitness.Frog

{
    class Program
    {
        static void Main()
        {
            // Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");

            string entry = Console.ReadLine();

            // Add minutes exercised to total
            // Display total minutes exercised to the screen
            Console.WriteLine("You've entered " + entry + " minutes");
            // Repeat until the user quits
        }
    }
}
