using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class ElephantSpecies : ArtiodactylsSquad
    {
        public ElephantSpecies(
          string name,
          double weight,
          bool isCirculatorySystem,
          double height,
          double woolLength,
          EatingType eatingType,
          string hoofShape,
          double earsWidth,
          double trunkLength,
          string subSpecies)
          : base(name, weight, isCirculatorySystem, height, woolLength, eatingType, hoofShape)
        {
            EarsWidth = earsWidth;
            TrunkLength = trunkLength;
            SubSpecies = subSpecies;
        }

        public double EarsWidth { get; set; }
        public double TrunkLength { get; set; }
        public string SubSpecies { get; set; }
    }
}
