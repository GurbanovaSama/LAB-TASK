using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassTask
{
    internal class Car : Vehicle
    {
        public string brand = "Mercedes";
        public string model = "C-Class";
        public double fuelCapacity = 60;
        public double fuelFor1km = 0.07;
        public double currentFuel = 50;
        public double distance = 20;


        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{brand}, Model:{model}, Fuel Capacity:{fuelCapacity}, Current Fuel:{currentFuel}");
        }


        public void Drive()
        {
           
            double fuelForDistance = distance * fuelFor1km;
         
            if (currentFuel >= fuelForDistance)
            {
                currentFuel -= fuelForDistance;
                Console.WriteLine($"Gedilen mesafe: {distance} , qalan yanacaq tutumu {currentFuel}");
            }
            else
            {
                Console.WriteLine("Kifayet qeder yanacaq yoxdur");
            }

        }

    }
}
