using System;
using System.Collections.Generic;
using System.Text;

namespace home_task_1__7_
{
    internal class Task: IComparable
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public Task(int taskID, string desc, int priority)
        {
            TaskID = taskID;
            Description = desc;
            Priority = priority;
        }

        public Task(string desc, int priority)
        {
            Description = desc;
            Priority = priority;
        }
        public int CompareTo(object? obj)
        {
            return Priority.CompareTo(((Task)obj).Priority);
        }
    }
}
