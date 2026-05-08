using System;

namespace LearningCSharpNotes.Topic11_AbstractionInterface
{
    public class Teacher : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Teacher is teaching");
        }

        public void GetRole()
        {
            Console.WriteLine("Role: Teacher");
        }
    }
}