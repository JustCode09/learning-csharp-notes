using System;

namespace LearningCSharpNotes.Topic04_Methods
{
    public static class Topic04_Methods
    {
        public static void Demo()
        {
            Console.WriteLine("========== METHODS DEMO ==========\n");
            Console.WriteLine("Smart Calculator\n");

            // Get numbers using the method
            int num1 = GetNumber();
            int num2 = GetNumber();

            // Add them
            int sum = Add(num1, num2);
            Console.WriteLine($"Sum = {sum}");

            // Check if the sum is even or odd
            CheckEven(sum);
        }

        // Method to get a number from user
        private static int GetNumber()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        // Method to add two numbers
        private static int Add(int a, int b)
        {
            return a + b;
        }

        // Method to check if a number is even or odd
        private static void CheckEven(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}