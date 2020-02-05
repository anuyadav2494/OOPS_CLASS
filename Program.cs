using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CLASS
{
    class Program
    {
        


            static void Main(string[] args)
            {
                //Multiple Objects
                Car myobj1 = new Car();
                Car myobj2 = new Car();
                Console.WriteLine("Color of Car1 is : " + myobj1.color);
                Console.WriteLine("Model of Car2 is : " + myobj2.model);
                

                //ClassMembers
                CarsClassMembers car1 = new CarsClassMembers();
                CarsClassMembers car2 = new CarsClassMembers();
                car1.color = "red";
                car1.model = "BMW";
                car1.year = 2018;

                car2.color = "blue";
                car2.model = "Audi";
                car2.year = 2019;
                Console.WriteLine("--------Class Members--------");
                car1.MaxSpeed();
                car2.MaxSpeed();
                
                Console.WriteLine("Color of Car1 is : " + car1.color);
                Console.WriteLine("Model of Car1 is : " + car1.model);
                Console.WriteLine("Color of Car2 is : " + car2.color);
                Console.WriteLine("Year of Car2 is : " + car2.year);


            // Constructor
            CarConstructor CarCon = new CarConstructor("BMW",1989);
            Console.WriteLine("--------Constructors--------");
            Console.WriteLine("Model of Car1 is : " + CarCon.model);
            Console.WriteLine("Year of Car1 is : " + CarCon.year);


            //Properties
            Console.WriteLine("--------Properties--------");
            CarProperties carprop = new CarProperties();
            carprop.Name = "Benz";
            Console.WriteLine("Name is :" + carprop.Name);


            // Inheritance
            Console.WriteLine("--------Inheritance-------");
            CarInhert carinher = new CarInhert();
            
            carinher.start();
            Console.WriteLine("Series of Car :" + carinher.model);
            Console.ReadLine();

            }
        
    }
    
}
    

