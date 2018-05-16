using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class HelloModels
    {
        public static List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle> {
                new Car { Id = 1, Make = "Ford", Model = "Mustang", Year = 1967 },
                new Car { Id = 2, Make = "Chevrolet", Model = "Silverado", Year = 1996},
                new Car { Id = 3, Make = "Audi", Model = "A6", Year = 2003 },
                new Car { Id = 4, Make = "Ford", Model = "F150", Year = 2004 },
                new Motorcyle { Id = 5, Make = "Kawasaki", Model = "KZ250", Year = 2003 },
                new Motorcyle { Id = 6, Make = "Honda", Model = "VFR700", Year = 1986 },
                new Motorcyle { Id = 7, Make = "Yamaha", Model = "YZFR1", Year = 2003 },
                new Car { Id = 8, Make = "Ford", Model = "Fusion", Year = 2008 },
                new Car { Id = 9, Make = "Subaru", Model = "Impreza WRX", Year = 2005 },
                new Car { Id = 10, Make = "Volkswagen", Model = "Jetta", Year = 2001 },
                new Motorcyle { Id = 11, Make = "Honda", Model = "Goldwing 1500", Year = 1986 },
                new Car { Id = 12, Make = "Audi", Model = "A4 Ultrasport", Year = 2004 },
                new Motorcyle { Id = 13, Make = "Suzuki", Model = "GS1100", Year = 1983 },
                new Car { Id = 14, Make = "Audi", Model = "A3 Sportback", Year = 2007 }
            };
            return vehicles;
        }
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    public class Car : Vehicle 
    {
        public int Wheels = 4;
    }
    public class Motorcyle : Vehicle
    {
        public int Wheels = 2;
    }
}