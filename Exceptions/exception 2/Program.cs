namespace exception_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000;
            string id = "";
            string credit = "";
            int amount = 0;
            bool isSucccess = false;
            while (!isSucccess)
            {
                Console.Clear();
                try
                {
                    
                    Console.WriteLine("please enter your card number: ");
                    credit = Console.ReadLine();
                    bool isCardLenghtValid = (credit.Length == 16);
                    if (!isCardLenghtValid)
                    {
                        if (credit.Length > 16)
                            throw new OverflowException("the card number is to long.");
                        else
                            throw new OverflowException("the card number is to short.");
                    }

                    Console.WriteLine("please enter your id number: ");
                    id = Console.ReadLine();
                    bool isIdLenghtValid = (id.Length == 9);
                    if (!isIdLenghtValid)
                    {
                        if (id.Length > 9)
                            throw new OverflowException("the id number is to long");
                        else
                            throw new OverflowException("the id number is to short");
                    }

                   
                    long creditNum = long.Parse(credit);
                    long idNum = long.Parse(id);
                   
                    Console.WriteLine("please enter the amount you need: ");
                    amount = int.Parse(Console.ReadLine());
                    if (amount > balance)
                    {
                        throw new FormatException("there is not enough cash in the balance.");
                    }

                    balance = (balance - amount);

                    Console.WriteLine($"account balance: {balance}");

                    isSucccess = true;
                }

                catch (OverflowException ofe)
                {
                    Console.WriteLine(ofe.Message);
                    Console.WriteLine("press any key to try again..");
                    Console.ReadKey();                 
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("press any key to try again..");
                    Console.ReadKey();
                }
            }

        }
    }
}
