using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public abstract class Chordates : Animals
    {
        public Chordates(string name, double weight, bool isCirculatorySystem, double height, double woolLength, EatingType eatingType)
            : base(name, weight, isCirculatorySystem)
        {
            Height = height;
            WoolLength = woolLength;
            EatingType = eatingType;
        }

        public double Height { get; set; }
        public double WoolLength { get; set; }
        public EatingType EatingType { get; set; }
    }
}
