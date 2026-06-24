namespace class_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance[] appliances = new Appliance[] 
            { 
            new Appliance(){Price= 100}, 
            new Appliance(){Price= 87},
            new Appliance(){Price= 45}
            };

            foreach (Appliance appliance in appliances)
            {
                Console.WriteLine(appliance.Price);
            }
            Console.WriteLine();

            Array.Sort(appliances);
            foreach (Appliance appliance in appliances)
            {
                Console.WriteLine(appliance.Price);
            }
        }
    }
}
