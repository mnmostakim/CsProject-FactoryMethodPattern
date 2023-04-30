using Ex_Monthly_03_Project.Factories;
using Ex_Monthly_03_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Monthly_03_Project.Tests
{
    public class TestClass
    {
        private readonly IObjectFactory factory;
        public TestClass(IObjectFactory factory) 
        { 
            this.factory = factory;
        }
        public void TestMethod()
        {
            var carModels = new CarModel[]
            {
                factory.Create<CarModel>(1, "BMW XI"),
                factory.Create<CarModel>(2, "Toyota"),
                factory.Create<CarModel>(1, "Nissan")
            };
            Console.WriteLine("Models");
            carModels
                .ToList()
                .ForEach(cm => Console.WriteLine($"{cm.Id} {cm.ModelName}"));
            Console.WriteLine();
            var cars = new Car[]
            {
                 factory.Create<Car>(1,1,4200,10  ),
                factory.Create<Car>(2, 2,3200, 6 ),
                factory.Create<Car>(3, 3,3200, 6 )
            };
            Console.WriteLine("Cars");
            cars
                .ToList()
                .ForEach(c => Console.WriteLine($"{c.ModelId} Seats:{c.NumberOfSeats}, Engine: {c.EngineCapacity}cc"));
            
        }
    }
}
