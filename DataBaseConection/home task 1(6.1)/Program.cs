namespace home_task_1_6._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Store s = new Store();
            Console.WriteLine(s);
            s.AddItem(new Item("milkey", 6, "Milky is popular in Israel"));
            s.AddItem(new Item("cottage", 4, "Basic dairy product"));
            Console.WriteLine(s);


            Console.WriteLine(s);

            s.DeleteItem(1);
            Console.WriteLine(s);
        }
    }
}
