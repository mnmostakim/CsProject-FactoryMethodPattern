using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Monthly_03_Project.Models
{
    public class Car 
    {
        public Car() { }
        public Car(int id, int modelId, int engineCapacity, int numberOfSeats)
        {
            Id = id;
            ModelId = modelId;
            EngineCapacity = engineCapacity;
            NumberOfSeats = numberOfSeats;
        }
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int EngineCapacity { get; set; }
        public int NumberOfSeats { get; set; }

    }
}
