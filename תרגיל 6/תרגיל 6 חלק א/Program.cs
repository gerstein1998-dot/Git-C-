namespace תרגיל_6_חלק_א
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine(s);

            s.AddItem(new Item("milkey", "milkey is popular in Israel", 6));
            s.AddItem(new Item("cottage", "basic dairy produce", 4));
            Console.WriteLine(s);

            s.DeleteItem(1);
            Console.WriteLine(s);

        }
    }
}
