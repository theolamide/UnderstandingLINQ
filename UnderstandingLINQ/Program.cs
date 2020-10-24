using System;
using System.Collections.Generic;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "Toyota", Model = "Camry", Year = 2010, StickerPrice = 25000};
            }

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }   
        public int StickerPrice { get; set; }
    }
}