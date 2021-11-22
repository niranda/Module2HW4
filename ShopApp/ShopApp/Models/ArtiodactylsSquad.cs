namespace ShopApp.Models
{
    public abstract class ArtiodactylsSquad : Chordates
    {
        public ArtiodactylsSquad(
            string name,
            double weight,
            bool isCirculatorySystem,
            double height,
            double woolLength,
            EatingType eatingType,
            string hoofShape)
            : base(name, weight, isCirculatorySystem, height, woolLength, eatingType)
        {
            HoofShape = hoofShape;
        }

        public string HoofShape { get; set; }
    }
}
