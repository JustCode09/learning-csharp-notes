using System;

namespace LearningCSharpNotes.Topic11_AbstractionInterface
{
    public class Student : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Student is studying");
        }

        public void GetRole()
        {
            Console.WriteLine("Role: Student");
        }
    }
}