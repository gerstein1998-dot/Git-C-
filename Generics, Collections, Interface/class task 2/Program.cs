namespace class_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number(1, 8, 3, 6, 99, 10, 55, 10);
            static void Number(params int[] numbers)
            {
                Queue<int> queue = new Queue<int>();
                Stack<int> stack = new Stack<int>();

                foreach (int i in numbers)
                {
                    queue.Enqueue(i);
                }
                while (queue.Count > 0)
                {
                    stack.Push(queue.Dequeue());

                }
                while (stack.Count > 0)
                {
                    Console.WriteLine(stack.Pop());
                }
            }
        }
    }
}
