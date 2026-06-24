namespace class_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Car("123", 180);
            vehicles[1] = new Bicycle("456", 20);
            vehicles[2] = new Car("789", 90);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("--------------------------------");
                vehicle.ToString();
                vehicle.Move();

                if (vehicle is Car)
                {
                    ((Car)vehicle).TurnOnAirConditioner();
                }


                Console.WriteLine();
            }
            Console.WriteLine("---testing equals--");
            Car c1 = new Car("9999", 120);
            Car c2 = new Car("9999", 85);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("are cars equals? " + c1.Equals(c2));
        }
    }
}
