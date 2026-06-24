namespace class_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RoundTable knights = new RoundTable();

            Console.WriteLine(knights.ToString());

            knights.AddKnight(new Knight("Low", "Grade", "Electric Knight"));

            Console.WriteLine(knights.ToString());

            knights.DeleteKnightFromDB(1);

            Console.WriteLine(knights.ToString());

            Console.WriteLine(knights.PrintKnightByPower("Fire Knight"));
        }
    }
}
