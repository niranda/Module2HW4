using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public abstract class Animals
    {
        public Animals(string name, double weight, bool isCirculatorySystem)
        {
            Name = name;
            Weight = weight;
            IsCirculatorySystem = isCirculatorySystem;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public bool IsCirculatorySystem { get; set; }
    }
}
