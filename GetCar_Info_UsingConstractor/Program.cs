using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCar_Info_UsingConstractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car("Ford", "Mustang", 2021, "red");                 // create object / assign a identifier 
            car car2 = new car("Chevy", "Carvetta", 2020, "Blue");
            
            car1.drive();                                                         // here we using the drive method
            car2.drive();


            Console.ReadKey();
        }
        class car                        //Make a class for a car to know model, year and color
        {
            string make;
            string model;
            int year;
            string color;

            public car(string make,  string model, int year, string color)                  //make a constractor same name as class and using arguments
            {
                this.make = make;
                this.model = model;
                this.year = year;
                this.color = color;
            }
            public void drive()                         //assign a method 
            {
                Console.WriteLine("You Drive the " + make + " " + model);
            }
        }

    }
}
