using System;
using System.Collections.Generic;
using System.Text;

namespace task_manager_task_7
{
    internal class Task : IComparable<Task>
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public Task(int taskId, string description, int priority)
        {
            TaskId = taskId;
            Description= description;
            Priority = priority;
        }

        public int CompareTo(Task other)
        {
            if (other == null) return 1;
            if (this.Priority < other.Priority) return -1;
            if (this.Priority > other.Priority) return 1;
            return 0;
        }
    }

}
