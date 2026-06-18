namespace class_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emploee e1 = new Emploee("avi", 5000);
            Manager m1 = new Manager("beni", 10000, 10);

            Emploee[] emploees = new Emploee[] { e1, m1 };

            for (int i = 0; i < emploees.Length; i++)
            {
                emploees[i].Work();


                if (emploees[i].GetType() == typeof(Manager) )
                {
                    Manager mgr = (Manager)emploees[i];
                    mgr.AssignBonus();
                }
                Console.WriteLine();
            }
        }
    }
}
