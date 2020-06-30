using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE 

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable = false)

            //BONUS X 2 
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            CarLot carLot = new CarLot();

            //Standard Member Initialization  
            Car car1 = new Car();
            carLot.carList.Add(car1);    //Add car1 to the CarLot List
            car1.Year = 2020;
            car1.Make = "Ford";
            car1.Model = "Escape";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Honk Honk";
            car1.IsDriveable = false;

            Console.WriteLine($"Car1 {car1.Year} {car1.Make} {car1.Model}");
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine();

            //Object Initializer Syntax                       
            Car car2 = new Car()
            {
                Year = 2019,
                Make = "Toyota",
                Model = "Camry",
                EngineNoise = "Smooth",
                HonkNoise = "Beep Beep"               
            };
            carLot.carList.Add(car2);  //Add car2 to the CarLot List
            Console.WriteLine($"Car2 {car2.Year} {car2.Make} {car2.Model}");
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine();

            //Parameterized Constructor Initialization syntax
            Car car3 = new Car(2018, "Honda", "CRV", "Real Quiet", "Bee Boop");
            carLot.carList.Add(car3);  //Add car3 to the CarLot List
            Console.WriteLine($"Car3 {car3.Year} {car3.Make} {car3.Model}");
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            Console.WriteLine();

            //*************BONUS X 2*************//

            //DONE -Create a CarLot class
            //DONE - It should have at least one property: a List of cars
            //DONE - Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console                    
            foreach (Car car in carLot.carList) 
            {
                Console.WriteLine($"Year = {car.Year} Make = {car.Make} = Model {car.Model}");                
            }
        }
    }
}
