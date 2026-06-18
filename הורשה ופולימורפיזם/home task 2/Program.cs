namespace home_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PassengerPlane pass1 = new PassengerPlane(1000, "BKK10", 250);
            PassengerPlane pass2 = new PassengerPlane(4000, "TLV10", 120);
            FighterJet f1 = new FighterJet(8000, "Kiler");
            FighterJet f2 = new FighterJet(7000, "BoomShakaLak");

            Aircraft[] aircrafts = new Aircraft[] { pass1, pass2, f1, f2 };

            for (int i = 0; i < aircrafts.Length; i++)
            {
                aircrafts[i].PrintStatus();

                if (aircrafts[i].GetType() == typeof(FighterJet))
                {
                   ( (FighterJet)aircrafts[i]).FireMissile();
                }
                Console.WriteLine("----------");
            }
        }
    }
}
