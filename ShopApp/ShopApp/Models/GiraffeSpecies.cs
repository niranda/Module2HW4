namespace ShopApp.Models
{
    public class GiraffeSpecies : ArtiodactylsSquad
    {
        public GiraffeSpecies(
           string name,
           double weightInKg,
           bool isCirculatorySystem,
           double heightInCm,
           double woolLengthInMm,
           EatingType eatingType,
           string hoofShape,
           double neckLengthInCm,
           double numberOfSpots)
           : base(name, weightInKg, isCirculatorySystem, heightInCm, woolLengthInMm, eatingType, hoofShape)
        {
            NeckLengthInCm = neckLengthInCm;
            NumberOfSpots = numberOfSpots;
        }

        public double NeckLengthInCm { get; set; }
        public double NumberOfSpots { get; set; }
    }
}
