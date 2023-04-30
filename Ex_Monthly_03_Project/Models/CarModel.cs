using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Monthly_03_Project.Models
{
    public class CarModel 
    {
        public CarModel() { }
        public CarModel(int id, string modelName)
        {
            this.Id = id;
            this.ModelName = modelName;
        }
        public int Id { get; set; }
        public string ModelName { get; set; }
    }
}
