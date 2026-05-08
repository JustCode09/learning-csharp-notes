using System;

namespace LearningCSharpNotes.Topic01_VariablesIO
{
    public static class Topic01_VariablesIO
    {
        public static void Demo()
        {
            Console.WriteLine("========== VARIABLES & INPUT/OUTPUT ==========\n");
            Console.WriteLine("User Info App\n");

            // Ask for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Ask for age
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask for favorite number
            Console.Write("Enter your favorite number: ");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());

            // Output
            Console.WriteLine($"\nHello {name}!");
            Console.WriteLine($"You are {age} years old.");
            Console.WriteLine($"Your favorite number is {favoriteNumber}.\n");

            // Bonus: age after 5 years
            Console.WriteLine($"In 5 years, you will be {age + 5} years old.");
            Console.WriteLine($"Your favorite number multiplied by 2 is {favoriteNumber * 2}.");
        }
    }
}