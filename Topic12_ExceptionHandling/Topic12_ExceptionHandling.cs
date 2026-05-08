using System;

namespace LearningCSharpNotes.Topic12_ExceptionHandling
{
    public static class Topic12_ExceptionHandling
    {
        public static void Demo()
        {
            Console.WriteLine("========== EXCEPTION HANDLING DEMO ==========\n");
            Console.WriteLine("Safe Division Calculator\n");

            bool valid = false;
            while (!valid)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter whole numbers only.\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero! Try again.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}\n");
                }
            }
        }
    }
}