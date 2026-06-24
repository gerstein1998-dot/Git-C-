using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1__7_
{
    internal class TaskManager
    {
        Dictionary<int, Task> taskD;
        Stack<Task> UndoHistory;

        public TaskManager()
        {
            taskD = new Dictionary<int, Task>();
            UndoHistory = new Stack<Task>();
        }

        public Task GetTask(int taskID)
        {
            if (taskD.ContainsKey(taskID))
            {
                return taskD[taskID];
            }
            else
                return null;
        }

        public void AddTask(Task task)
        {
            taskD.Add(task.TaskID, task);
        }

        public void RemoveTask(int TaskID)
        {
            if (taskD.ContainsKey(TaskID))   // האם המספר משימה שווה לאחד המפתחות במילון ?
            {
                UndoHistory.Push(taskD[TaskID]);    // לפני שמוחקים תדחוף למחסנית היסטורית מחיקה

                taskD.Remove(TaskID);        // אם כן תמחוק אותה מהמילון
            }
        }

        public void UndoRemove()
        {
            while (UndoHistory.Count > 0) // כל עוד המחסנית מלאה 
            {
                Task restoreg = UndoHistory.Pop(); //תוציא לי מהמחסנית את המשימה לתוך המחלקה משימה חזרה 
                taskD.Add(restoreg.TaskID, restoreg); // ותכניס אותה בחזרה למילון 
            }
        }

        public void PrintAllSorted()
        {
            Task[] sortedTask = new Task[taskD.Count];  //יוצר מערך חדש בגודל המילון שיש לנו 
            taskD.Values.CopyTo(sortedTask, 0); //תעתיק לי את הערכים מהמילו למערך החדש החל מהמיקום 0 

            // ממיין לי הפונקציה שמימשנו במשימה של COMPARTO
            Array.Sort(sortedTask);

            Console.WriteLine("-----------------------------");

            //עבור כל אחד מערכים במערך תדפיס לי את העדיפות, התיאור, והמשפר משימה והכל ממויין לפי סדר עדיפפויות של המשימות
            foreach (Task task in sortedTask)
            {
                Console.WriteLine($"Priority: {task.Priority}, Description: {task.Description}, TaskID: {task.TaskID}"+"\n");  
            }
        }
    }
    }

