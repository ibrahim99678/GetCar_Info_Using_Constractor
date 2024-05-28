using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01StaticModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WE ARE GOING TO MAKE A APP TO KNOW HOW MANY CARS WAS IN A RACE?

            //Static : Modifier to decliar a static member, which belongs to the class itself
            // rather than to any specific object

            Car car1 = new Car("Mustang");                 //object has ownership of it so, that is the static 
            Car car2 = new Car("Chevy");
            Car car3 = new Car("LamBergini");           //Just add another object


            Console.WriteLine(Car.numberOfCars);        // Assign the main class.
            Car.StartRace();                            // startRace ststic method we are using here through parentases



 
            Console.ReadKey();
        }
        class Car                                       // class is own this properties
        {
            String make;
            public static int numberOfCars;             // we just make here static and its own this by using static

            public Car(String make)
            {
                this.make = make;
                numberOfCars++;
            }
            public static void StartRace()              //using a static modifier to a method 

            {
                Console.WriteLine("The Race has Begun!");
            }                           

        }
    }
}
