namespace class_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] listcar = new Car[]
            {
            new Mazda(2010, "Mazda 3", "Tom"),
            new Audi(2014,"A3", 200)
            };

            string option;
            do
            {
                Console.WriteLine(" Please enter: \n1 - Travel of all cars" +
                    "\n2 - Print all cars." +
                    "\n3 - Sort by gas quantity" +
                    "\n4 - Sort by car modle" +
                    "\n5 - Exit");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        int kilometer;
                        foreach (Car item in listcar)
                        {
                            Console.WriteLine("how many kilometer does the car trip takes?");
                            kilometer = int.Parse(Console.ReadLine());
                            item.Drive(kilometer);
                        }
                        break;
                    case "2":
                        foreach (Car item in listcar)
                        {
                            Console.WriteLine(item + "\n");
                        }
                        break;
                    case "3":
                        Car.sortByGas = true;
                        Array.Sort(listcar);
                        foreach (Car item in listcar)
                        {
                            Console.WriteLine(item + "\n");
                        }
                        break;
                    case "4":
                        Car.sortByGas = false;
                        Array.Sort(listcar);
                        foreach (Car item in listcar)
                        {
                            Console.WriteLine(item + "\n");
                        }
                        break;
                    case "5":
                        Console.WriteLine("bye bye");
                        break;
                            default:
                        Console.WriteLine("There is no such option in the menu try again");
                        break;


                }
            }
            while (option != "5");
         }
    }
}

