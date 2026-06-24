namespace class_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance[] appliances = new Appliance[] 
            { 
            new Oven(){Brand = "Bosch"},
            new WashingMachine(){Brand= "Electra"},
             new Oven(){Brand = "Smeg"},
            new WashingMachine(){Brand= "LG"}
            };

            foreach (var appliance in appliances)
            {
                appliance.TurnOn();
            }
    }
}
}
