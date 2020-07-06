using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {//This is a class for the Car Lot that is a List of the Cars 

        //Static Keyword Exercise 2- Create a static field called number of Cars
        public static int _numberOfCars;
        public List<Car> carList { get; set; } = new List<Car>();
    }
}
