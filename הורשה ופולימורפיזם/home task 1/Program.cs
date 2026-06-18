namespace home_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(10, 1000);
            VipAccount vip1 = new VipAccount(11, 1000);

            Console.WriteLine("please enter the amount you need: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write($"regular account ");
            a1.Withdraw(amount);
            Console.Write($"VIPaccount ");
            vip1.Withdraw(amount);
        }
    }
}
