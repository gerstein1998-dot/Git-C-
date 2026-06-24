namespace class_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Team team = new Team();
            team.AddPlayer("moshe");
            team.AddPlayer("yuval");
            team.AddPlayer("yossi");

            Console.WriteLine("the team players are:");
            team.PrintPlayers();



    }
}
}
