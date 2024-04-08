using Properties;
using System;

namespace Properties_Bruner_Zach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enters Ford Mustang into the system
            car car = new car();
            car.Make = "Ford";
            car.Model = "Mustang";
            // Makes the car run into the comman prompt
            Console.WriteLine($"Make {car.Make}, Model: {car.Model}");
            // Makes a New Chevy Camero into the command prompt
            car car2 = new car();
            car2.Make = "Chevy";
            car2.Model = "Camero";
            Console.WriteLine($"Make {car2.Make}, Model: {car2.Model}");
            // Enters MAke and model into the system for car 3
            car car3 = new car();
            Console.WriteLine($"Make {car3.Make}, Model: {car3.Model}");
        }
    }
}
