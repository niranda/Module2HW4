using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class WolfSpecies : PredatorsSquad
    {
        public WolfSpecies(
            string name,
            double weight,
            bool isCirculatorySystem,
            double height,
            double woolLength,
            EatingType eatingType,
            double fangsLength,
            bool isYellingOnMoon)
            : base(name, weight, isCirculatorySystem, height, woolLength, eatingType, fangsLength)
        {
            IsYellingOnMoon = isYellingOnMoon;
        }

        public bool IsYellingOnMoon { get; set; }
    }
}
