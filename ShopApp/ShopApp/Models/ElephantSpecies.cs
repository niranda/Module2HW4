namespace ShopApp.Models
{
    public class ElephantSpecies : ArtiodactylsSquad
    {
        public ElephantSpecies(
          string name,
          double weightInKg,
          bool isCirculatorySystem,
          double heightInCm,
          double woolLengthInMm,
          EatingType eatingType,
          string hoofShape,
          double earsWidthInCm,
          double trunkLengthInCm,
          string subSpecies)
          : base(name, weightInKg, isCirculatorySystem, heightInCm, woolLengthInMm, eatingType, hoofShape)
        {
            EarsWidthInCm = earsWidthInCm;
            TrunkLengthInCm = trunkLengthInCm;
            SubSpecies = subSpecies;
        }

        public double EarsWidthInCm { get; set; }
        public double TrunkLengthInCm { get; set; }
        public string SubSpecies { get; set; }
    }
}
