namespace LearningCSharpNotes.Topic09_Polymorphism
{
    public class Student : Person
    {
        public int marks;

        public override void ShowRole()
        {
            Console.WriteLine("I am a student");
        }
    }
}
