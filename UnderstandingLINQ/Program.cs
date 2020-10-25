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
                new Car() { VIN = "A1", Make = "Toyota", Model = "Camry", Year = 2010, StickerPrice = 25000 },
                new Car() { VIN = "B2", Make = "Volkswagen", Model = "Jetta", Year = 2009, StickerPrice = 32000 },
                new Car() { VIN = "C3", Make = "Mercedes", Model = "CLS250", Year = 2011, StickerPrice = 30000 }
            };

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