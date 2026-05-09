using System;
using System.Collections.Generic;

namespace LearningCSharpNotes.Topic05_ArraysLists
{
    public static class Topic05_ArraysLists
    {
        public static void Demo()
        {
            Console.WriteLine("========== ARRAYS & LISTS DEMO ==========\n");
            Console.WriteLine("Student Marks System\n");

            // Ask how many students
            Console.Write("How many students? ");
            int count = Convert.ToInt32(Console.ReadLine());

            // Create a List<int> to store marks
            List<int> marks = new List<int>();

            // Loop to take marks
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter mark for student {i}: ");
                int mark = Convert.ToInt32(Console.ReadLine());
                marks.Add(mark);
            }

            // Print all marks
            Console.Write("\nMarks: ");
            foreach (int m in marks)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            // Calculate total and average
            int total = 0;
            foreach (int m in marks)
            {
                total += m;
            }
            double average = (double)total / count;

            Console.WriteLine($"Total = {total}");
            Console.WriteLine($"Average = {average}");

            // Bonus: highest and lowest marks
            int highest = marks[0];
            int lowest = marks[0];
            foreach (int m in marks)
            {
                if (m > highest) highest = m;
                if (m < lowest) lowest = m;
            }
            Console.WriteLine($"Highest mark = {highest}");
            Console.WriteLine($"Lowest mark = {lowest}");
        }
    }
}