namespace LearningCSharpNotes.Topic09_Polymorphism
{
    public class Teacher : Person
    {
        public int salary;

        public override void ShowRole()
        {
            Console.WriteLine("I am a teacher");
        }
    }
}