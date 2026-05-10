namespace מערך__תרגול_מחלקות_מופשטות_וממשקים
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance[] appliances =
            {
                new Oven("LG"),
                new washingMachine("samaung"),
                new Oven("Bosh"),

            };

            foreach (Appliance a in appliances)
            {
                a.TurnOn();
            }
        }
    }
}
