namespace class_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("privat car", 1998, 2);
            c1.PrintDetails();

            Car c2 = new Car("track", 2022, 4);
            c2.PrintDetails();
        }
    }
}
