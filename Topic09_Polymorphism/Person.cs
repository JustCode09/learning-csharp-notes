using System;

namespace LearningCSharpNotes.Topic09_Polymorphism
{
    public class Person
    {
        public string name;
        public int age;

        public virtual void ShowRole()
        {
            Console.WriteLine("Person has a generic role.");
        }
    }
}