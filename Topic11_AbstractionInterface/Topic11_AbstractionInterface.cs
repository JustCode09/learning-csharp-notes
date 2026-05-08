using System;

namespace LearningCSharpNotes.Topic11_AbstractionInterface
{
    public static class Topic11_AbstractionInterface
    {
        public static void Demo()
        {
            Console.WriteLine("========== ABSTRACTION & INTERFACE DEMO ==========\n");

            // Using interface references
            IWorker w1 = new Student();
            IWorker w2 = new Teacher();

            w1.Work();
            w1.GetRole();

            w2.Work();
            w2.GetRole();

            // Bonus: list of workers
            Console.WriteLine("\n--- All workers ---");
            List<IWorker> workers = new List<IWorker> { new Student(), new Teacher() };
            foreach (var w in workers)
            {
                w.Work();
            }
        }
    }
}