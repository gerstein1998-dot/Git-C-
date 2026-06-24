using System.Security.Cryptography.X509Certificates;

namespace class_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartP = new Smartphone();
            ElectricCar electricC = new ElectricCar();

            StartCharging(smartP);
            StartCharging(electricC);

        }
        static void StartCharging(IRechargeable device)
        {
            device.Recharge();
        }
       
    }
}
