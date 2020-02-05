using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CLASS
{
    class Car
    {
        public string color = "red";
        public string model = "BMW";

    }
    class CarsClassMembers
    {
        public string color;
        public string model;
        public int year;
        public void MaxSpeed()
        {
            Console.WriteLine("Car is going as fast as it can ---");
        }

    }
    class CarConstructor
    {
        public string model;
        public int year;
        public  CarConstructor(string modelname, int yearofmanufacturing)
        {
            model = modelname;
            year = yearofmanufacturing;
        }
    }

    class CarProperties
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }
    class Vehicle
    {
        public string brand = "BMW";
        public void start()
        {
            Console.WriteLine("Car is started");
        }
    }
    class CarInhert : Vehicle
    {
        public string model = "A series";
    }

   class VehiclesPoly
    {
        public void Horn()
        {
            Console.WriteLine("All vehicles horn");
        }
    }
    class Cars : VehiclesPoly
    {
        public void Horn()
        {
            Console.WriteLine("All Cars horn");
        }

    }
    class Buses : VehiclesPoly
    {
        public void Horn()
        {
            Console.WriteLine("All Buses horn");
        }

    }
}
