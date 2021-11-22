namespace ShopApp.Models
{
    public abstract class ArtiodactylsSquad : Chordates
    {
        public ArtiodactylsSquad(
            string name,
            double weightInKg,
            bool isCirculatorySystem,
            double heightInCm,
            double woolLengthInMm,
            EatingType eatingType,
            string hoofShape)
            : base(name, weightInKg, isCirculatorySystem, heightInCm, woolLengthInMm, eatingType)
        {
            HoofShape = hoofShape;
        }

        public string HoofShape { get; set; }
    }
}
