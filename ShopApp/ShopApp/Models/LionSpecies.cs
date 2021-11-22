using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class LionSpecies : PredatorsSquad
    {
        public LionSpecies(
            string name,
            double weight,
            bool isCirculatorySystem,
            double height,
            double woolLength,
            EatingType eatingType,
            double fangsLength,
            double maneDensity)
            : base(name, weight, isCirculatorySystem, height, woolLength, eatingType, fangsLength)
        {
            ManeDensity = maneDensity;
        }

        public double ManeDensity { get; set; }
    }
}
