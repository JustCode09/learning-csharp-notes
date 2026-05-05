namespace LearningCSharpNotes.Topic08_Inheritance
{
    // Student IS-A Person
    public class Student : Person
    {
        public int marks;

        // No need to redeclare name/age – they come from Person
    }
}