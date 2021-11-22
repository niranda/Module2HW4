namespace ShopApp.Models
{
    public class LionSpecies : PredatorsSquad
    {
        public LionSpecies(
            string name,
            double weightInKg,
            bool isCirculatorySystem,
            double heightInCm,
            double woolLengthInMm,
            EatingType eatingType,
            double fangsLengthInMm,
            double maneDensity)
            : base(name, weightInKg, isCirculatorySystem, heightInCm, woolLengthInMm, eatingType, fangsLengthInMm)
        {
            ManeDensity = maneDensity;
        }

        public double ManeDensity { get; set; }
    }
}
