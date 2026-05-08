using System;

namespace LearningCSharpNotes.Topic09_Polymorphism
{
    public static class Topic09_Polymorphism
    {
        public static void Demo()
        {
            Console.WriteLine("========== POLYMORPHISM DEMO ==========\n");

            Person p1 = new Student();
            Person p2 = new Teacher();

            p1.name = "Ram";
            p2.name = "Hari";

            p1.ShowRole();   // Output: I am a student
            p2.ShowRole();   // Output: I am a teacher
        }
    }
}