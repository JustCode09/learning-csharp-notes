using System;

namespace LearningCSharpNotes.Topic03_Loops
{
    public static class Topic03_Loops
    {
        public static void Demo()
        {
            Console.WriteLine("========== LOOPS DEMO ==========\n");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Number Repeater & Sum Calculator (main)");
            Console.WriteLine("2. Daily Steps Tracker");
            Console.WriteLine("3. Password System");
            Console.WriteLine("4. Multiplication Table");
            Console.WriteLine("5. Even Numbers Printer");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    MainDemo();
                    break;
                case "2":
                    StepsTracker();
                    break;
                case "3":
                    PasswordSystem();
                    break;
                case "4":
                    MultiplicationTable();
                    break;
                case "5":
                    EvenNumbers();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        // Original main demo
        private static void MainDemo()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numbers from 1 to {0}: ", n);
            for (int i = 1; i <= n; i++)
                Console.Write(i + " ");
            Console.WriteLine();

            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;
            Console.WriteLine($"Sum from 1 to {n} = {sum}");
        }

        // Practice 1: Steps Tracker
        private static void StepsTracker()
        {
            Console.WriteLine("How many days?");
            int days = Convert.ToInt32(Console.ReadLine());
            int totalSteps = 0;

            for (int i = 1; i <= days; i++)
            {
                Console.Write($"Enter steps for day {i}: ");
                int steps = Convert.ToInt32(Console.ReadLine());
                totalSteps += steps;
            }
            Console.WriteLine($"Total steps = {totalSteps}");
        }

        // Practice 2: Password System
        private static void PasswordSystem()
        {
            string password = "";
            while (password != "1234")
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
            }
            Console.WriteLine("Login successful!");
        }

        // Practice 3: Multiplication Table
        private static void MultiplicationTable()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        // Practice 4: Even Numbers Only
        private static void EvenNumbers()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Even numbers from 1 to {n}:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}