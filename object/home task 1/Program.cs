namespace home_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Dog("Bobi", 10);
            animals[1] = new Cat("Mitzi", 3);

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].ToString()); 

                if (animals[i] is Dog)
                {
                 ((Dog)animals[i]).Bark(); 
                }
                else
                {
                 ((Cat)animals[i]).Purr();
                }
                Console.WriteLine();
            }

        }
    }
}
