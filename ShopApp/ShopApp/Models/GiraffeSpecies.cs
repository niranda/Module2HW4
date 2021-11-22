using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class GiraffeSpecies : ArtiodactylsSquad
    {
        public GiraffeSpecies(
           string name,
           double weight,
           bool isCirculatorySystem,
           double height,
           double woolLength,
           EatingType eatingType,
           string hoofShape,
           double neckLength,
           double numberOfSpots)
           : base(name, weight, isCirculatorySystem, height, woolLength, eatingType, hoofShape)
        {
            NeckLength = neckLength;
            NumberOfSpots = numberOfSpots;
        }

        public double NeckLength { get; set; }
        public double NumberOfSpots { get; set; }
    }
}
