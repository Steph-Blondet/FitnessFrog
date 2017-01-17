using System; //declaring it here so we can stop writing "System" everytime.

namespace Treehouse.Fitness.Frog
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while(keepGoing)
            {
                // Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised: ");

                string entry = Console.ReadLine();

                int minutes = int.Parse(entry);

                // Add minutes exercised to total
                runningTotal = runningTotal + minutes;

                // Display total minutes exercised to the screen
                Console.WriteLine("You've entered " + runningTotal + " minutes");
                // Repeat until the user quits
            }
        }
    }
}
