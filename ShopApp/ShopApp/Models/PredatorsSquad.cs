using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public abstract class PredatorsSquad : Chordates
    {
        public PredatorsSquad(
            string name,
            double weight,
            bool isCirculatorySystem,
            double height,
            double woolLength,
            EatingType eatingType,
            double fangsLength)
            : base(name, weight, isCirculatorySystem, height, woolLength, eatingType)
        {
            FangsLength = fangsLength;
        }

        public double FangsLength { get; set; }
    }
}
