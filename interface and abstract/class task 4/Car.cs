using System;
using System.Collections.Generic;
using System.Text;

namespace class_task_4
{
    abstract class Car : IDrive, IComparable
    {
        public int year;
        public string model;
        public int fuel;
        public static bool sortByGas;

        public Car(int y, string m)
        {
            year = y;
            model = m;
            fuel = 100;
        }

        public int Kilometer { get; set; }

        public void Drive(int km)
        {
            if (km <= fuel)
            {
                Kilometer += km;
                fuel -= km;
                Console.WriteLine($"the number of km: {Kilometer}, the model is: {model}");
            }
            else
            {
                Console.WriteLine("not enough fuel :( ");
            }
        }

        public override string ToString()
        {
            return $"year: {year}, model: {model}, fuel: {fuel}, km: {Kilometer},";
        }

        public abstract void FillGas();

        public int CompareTo(object? obj)
        {
            if (sortByGas == true)
            {
                return fuel.CompareTo(((Car)obj).fuel);
            }
            else
            {
                return model.CompareTo(((Car)obj).model);
            }
        }
        
    }
}
