using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_2_Constructors
{
    internal class Car
    {
        public string Brand;
        public string Model;

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;

        }
        public void DisplayCars()
        {
            Console.WriteLine("\n------ Q2 ------");
            Console.WriteLine("Brand: "+Brand);
            Console.WriteLine("Model: "+Model);
        }
    }
}
