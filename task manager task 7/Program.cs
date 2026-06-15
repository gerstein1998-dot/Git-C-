namespace task_manager_task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
          TaskManager manager= new TaskManager();
            // מכניס ערכים לתוך משימות
            Task t1 = new Task(101, "do home work in math", 2);
            Task t2 = new Task(102, "cooking", 3);
            Task t3 = new Task(103, "workout", 1);
            Task t4 = new Task(104, "do home work in C#", 1);
            // שולח את כל אחד מהמשימות לתוך היומן משימות
            manager.AddTask(t1);
            manager.AddTask(t2);
            manager.AddTask(t3);
            manager.AddTask(t4);

            // להדפיס את כל המשימות לפי סדר הדחיפות שלהן
            manager.PrintAllSorted();
            Console.WriteLine();
            //למחוק את משימה 103
            manager.RemoveTask(103);
            manager.PrintAllSorted();
            Console.WriteLine();
            // להחזיר את משימה 103 מהמחסנית אקסטרה שעשינו 
            manager.UndoRemove();
            manager.PrintAllSorted();
        }
    }
    }



