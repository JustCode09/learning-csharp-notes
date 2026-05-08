using System;

namespace LearningCSharpNotes.Topic02_ControlFlow
{
    public static class Topic02_ControlFlow
    {
        public static void Demo()
        {
            Console.WriteLine("========== CONTROL FLOW (IF/ELSE) ==========\n");
            Console.WriteLine("Age & Number Checker\n");

            // Part 1: Age input and category
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string ageCategory;
            if (age < 13)
                ageCategory = "Child";
            else if (age <= 19)
                ageCategory = "Teenager";
            else
                ageCategory = "Adult";

            Console.WriteLine($"You are a {ageCategory}.");

            // Part 2: Favorite number even/odd
            Console.Write("\nEnter your favorite number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine($"{number} is an even number.");
            else
                Console.WriteLine($"{number} is an odd number.");

            // Bonus: adult and even
            if (age >= 18 && number % 2 == 0)
            {
                Console.WriteLine($"You are an even adult 😄");
            }
        }
    }
}