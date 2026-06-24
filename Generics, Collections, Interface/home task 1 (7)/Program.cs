namespace home_task_1__7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();

            //הכנסת משימות לתוך משימה
            Task t1 = new Task(101, "ללמוד למבחן בסיש", 1);
            Task t2 = new Task(102, "להכין אוכל", 2);
            Task t3 = new Task(103, "לשטוף כלים", 3);
            Task t4 = new Task(104, "להתאמן", 2);
            Task t5 = new Task(105, "להיות שמח", 1);
            Task t6 = new Task(106, "להיפגש עם חברים", 3);

            // מכניסה כל משימה למילון של המשימות
            manager.AddTask(t1);
            manager.AddTask(t2);
            manager.AddTask(t3);
            manager.AddTask(t4);
            manager.AddTask(t5);
            manager.AddTask(t6);

            Console.WriteLine("task by prioruty:");
            Console.WriteLine();
            manager.PrintAllSorted();
            Console.WriteLine();

            Console.WriteLine("choose which task to delet by TaskID:");
            Console.WriteLine();
            manager.RemoveTask(int.Parse(Console.ReadLine()));

            Console.WriteLine("task that left for you:");
            Console.WriteLine();
            manager.PrintAllSorted();
            Console.WriteLine();

            manager.UndoRemove();
            manager.PrintAllSorted();


        }
    }
}
