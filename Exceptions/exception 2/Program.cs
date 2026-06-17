namespace exception_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000;
            string id = "";
            string cardtNum = "";
            int amount = 0;
            bool isSucccess = false;
            while (!isSucccess)
            {
                try
                {
                    Console.WriteLine("please enter your id number: ");
                    id = Console.ReadLine();
                    if (id.Length < 9 || cardtNum.Length < 16)
                    {
                        throw new OverflowException(@"the credit \ id number  you enterd is too short.");
                    }
                    Console.WriteLine("please enter your card number: ");
                    cardtNum = Console.ReadLine();
                    if (id.Length > 9 ||)
                    {
                        throw new OverflowException();
                    }
                    bool isIdLenghtValid = (id.Length == 9);
                    bool isCardLenghtValid = (cardtNum.Length == 16);
                    if (isIdLenghtValid != isCardLenghtValid)
                    {
                        throw new FormatException();
                    }

                    Console.WriteLine("please enter the amount you need: ");
                    amount = int.Parse(Console.ReadLine());
                    if (amount > balance)
                    {
                        throw new FormatException();
                    }

                    isSucccess = true;
                }

                catch (OverflowException)
                {
                   
                    else
                    {
                        Console.WriteLine(@"the credit \ id number is too long.");
                    }
                    Console.WriteLine("press any key to try again..");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (FormatException)
                {
                    if (amount > balance)
                    {
                        Console.WriteLine("there is not enough cash in the balance.");
                    }
                    Console.WriteLine("press any key to try again..");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
    }
}
