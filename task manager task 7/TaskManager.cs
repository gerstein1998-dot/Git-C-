using System;
using System.Collections.Generic;
using System.Text;

namespace task_manager_task_7
{
    internal class TaskManager
    {
        private Dictionary<int, Task> myTM = new Dictionary<int, Task>();
        private Stack<Task> UndoHistory = new Stack<Task>();

        public Task GetTask(int TaskId)
        {
            if (myTM.ContainsKey(TaskId))
            {
                return myTM[TaskId];
            }
            else
            {
                return null;
            }

        }
        public void AddTask(Task newTask)
        {
            myTM.Add(newTask.TaskId, newTask);
        }

        public void RemoveTask(int taskId)
        {
            if (myTM.ContainsKey(taskId))
            {
                Task taskDelete = myTM[taskId];
                UndoHistory.Push(taskDelete);
                myTM.Remove(taskId);
            }

        }
        public void UndoRemove()
        {
            if (UndoHistory.Count > 0)
            {
                Task restoregedTask = UndoHistory.Pop();
                myTM.Add(restoregedTask.TaskId, restoregedTask);
            }
        }
        public void PrintAllSorted()
        {
            List<Task> sortedList = new List<Task>(myTM.Values);

            sortedList.Sort();

            foreach (Task task in sortedList)
            {
                Console.WriteLine($"ID: {task.TaskId}, Description: {task.Description}, priorty: {task.Priority}");
            }
        }
    }
}


