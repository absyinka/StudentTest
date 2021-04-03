using System;

namespace Umar
{
    public class Car
    {
        protected string color = "Silver";

        private int modelYear = 2008;

        public void GetModelYear()
        {
            Console.WriteLine(modelYear);
        }

        private void Drive()
        {
            Console.WriteLine("The car is in ignition!");
        }

        public void Iginition()
        {
            Drive();
        }
    }
}